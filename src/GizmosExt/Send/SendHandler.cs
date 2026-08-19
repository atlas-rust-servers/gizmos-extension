using Facepunch;
using Network;
#if CARBON
using Carbon;
#endif
#if OXIDE
using Oxide.Core;
#endif

namespace Oxide.Ext.GizmosExt;

internal static class SendHandler
{
    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7>(
        Connection connection, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
    {
        Send(SendInfoBuilder.Build(connection), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7>(
        IEnumerable<BasePlayer> players, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
    {
        Send(SendInfoBuilder.Build(players), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7>(
        IEnumerable<Connection> connections, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
    {
        Send(SendInfoBuilder.Build(connections), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
        Connection connection, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
    {
        Send(SendInfoBuilder.Build(connection), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7, a8));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
        IEnumerable<BasePlayer> players, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
    {
        Send(SendInfoBuilder.Build(players), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7, a8));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
        IEnumerable<Connection> connections, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
    {
        Send(SendInfoBuilder.Build(connections), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7, a8));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Connection connection, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
    {
        Send(SendInfoBuilder.Build(connection), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7, a8, a9));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        IEnumerable<BasePlayer> players, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
    {
        Send(SendInfoBuilder.Build(players), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7, a8, a9));
    }

    public static void Enqueue<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        IEnumerable<Connection> connections, string cmd,
        T0 a0, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
    {
        Send(SendInfoBuilder.Build(connections), CommandBuilder.Build(cmd, a0, a1, a2, a3, a4, a5, a6, a7, a8, a9));
    }

    private static void Send(SendInfo info, string command)
    {
        try
        {
            NetWrite write = Net.sv.StartWrite();
            write.PacketID(Message.Type.ConsoleCommand);
            write.String(command);
            write.Send(info);
        }
        catch (Exception ex)
        {
#if CARBON
            Logger.Error($"[GizmosFramework] An error occurred while sending gizmos: {ex}");
#endif
#if OXIDE
            Interface.Oxide.LogException("[GizmosFramework] An error occured while sending gizmos", ex);
#endif
        }
        finally
        {
            if (info.connections != null)
                Pool.FreeUnmanaged(ref info.connections);
        }
    }
}
