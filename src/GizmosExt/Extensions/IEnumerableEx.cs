using JetBrains.Annotations;
using Network;

namespace Oxide.Ext.GizmosExt;

// ReSharper disable once InconsistentNaming
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
internal static class IEnumerableEx
{
    public static List<Connection> GetOnlineConnectionsPooled(this IEnumerable<BasePlayer> players)
    {
        var list = Facepunch.Pool.Get<List<Connection>>();

        foreach (BasePlayer player in players)
        {
            if (!player.IsValid())
                continue;

            Connection connection = player.Connection;
            if (connection != null)
                list.Add(connection);
        }

        return list;
    }
}