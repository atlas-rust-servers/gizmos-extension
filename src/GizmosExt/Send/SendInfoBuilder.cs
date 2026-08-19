using Facepunch;
using Network;

namespace Oxide.Ext.GizmosExt;

internal static class SendInfoBuilder
{
    public static SendInfo Build(Connection connection)
    {
        return new SendInfo(connection);
    }

    public static SendInfo Build(IEnumerable<BasePlayer> players)
    {
        var list = Pool.Get<List<Connection>>();
        foreach (BasePlayer player in players)
            list.Add(player.Connection);

        return new SendInfo(list);
    }

    public static SendInfo Build(IEnumerable<Connection> connections)
    {
        var list = Pool.Get<List<Connection>>();
        list.AddRange(connections);
        return new SendInfo(list);
    }
}
