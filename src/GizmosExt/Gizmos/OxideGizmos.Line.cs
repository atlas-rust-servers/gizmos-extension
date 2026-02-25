using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render a line from point A to point B.
/// </summary>
public static partial class OxideGizmos
{
    private const string COMMAND_LINE = "ddraw.line";

    public static void Line([NotNull] Connection connection, float duration, Color color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_LINE, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line([NotNull] BasePlayer player, float duration, Color color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Line(player.Connection, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line([NotNull] IEnumerable<BasePlayer> players, float duration, Color color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_LINE, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line([NotNull] List<Connection> connections, float duration, Color color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_LINE, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line([NotNull] Connection connection, float duration, Vector3 color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_LINE, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line(BasePlayer player, float duration, Vector3 color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Line(player.Connection, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line([NotNull] IEnumerable<BasePlayer> players, float duration, Vector3 color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_LINE, duration, color, from, to, visibleDistance, zTest);
    }

    public static void Line([NotNull] List<Connection> connections, float duration, Vector3 color, Vector3 from, Vector3 to,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_LINE, duration, color, from, to, visibleDistance, zTest);
    }
}