using System.Collections.Concurrent;
using Facepunch;
using Network;
using Oxide.Core;

namespace Oxide.Ext.GizmosExt;

internal static class SendHandler
{
    private static CancellationTokenSource s_cts;

    private static readonly AutoResetEvent s_signal = new(false);
    private static readonly ConcurrentQueue<DDrawEntry> s_queue = new();

    public static void Initialize()
    {
        s_cts = new CancellationTokenSource();

        var thread = new Thread(Send)
        {
            IsBackground = true,
            Name = "GizmosFramework.SendHandler"
        };
        thread.Start();
    }

    public static void Shutdown()
    {
        s_cts.Cancel();
        s_signal.Set();
    }

    public static void Enqueue(Connection connection, string cmd, params object[] args)
    {
        var info = new SendInfo(connection);
        Enqueue(info, cmd, args);
    }

    public static void Enqueue(IEnumerable<BasePlayer> players, string cmd, params object[] args)
    {
        var list = Pool.Get<List<Connection>>();
        foreach (BasePlayer player in players)
            list.Add(player.Connection);

        var info = new SendInfo(list);
        Enqueue(info, cmd, args);
    }

    public static void Enqueue(IEnumerable<Connection> connections, string cmd, params object[] args)
    {
        var list = Pool.Get<List<Connection>>();
        list.AddRange(connections);

        var info = new SendInfo(list);
        Enqueue(info, cmd, args);
    }

    private static void Enqueue(SendInfo info, string cmd, params object[] args)
    {
        var entry = DDrawEntry.New(info, cmd, args);

        s_queue.Enqueue(entry);
        s_signal.Set();
    }

    private static void Send()
    {
        while (!s_cts.IsCancellationRequested)
        {
            while (s_queue.TryDequeue(out DDrawEntry entry))
            {
                try
                {
                    entry.Send();
                }
                catch (Exception ex)
                {
                    Interface.Oxide.NextTick(() => { Interface.Oxide.LogException("[GizmosFramework] An error occured while sending gizmos", ex); });
                }
                finally
                {
                    Pool.Free(ref entry);
                }
            }

            s_signal.WaitOne();
        }
    }
}