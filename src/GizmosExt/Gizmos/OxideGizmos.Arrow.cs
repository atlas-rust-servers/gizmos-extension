using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render an arrow from point A to point B.
/// </summary>
public static partial class OxideGizmos
{
    private const string COMMAND_ARROW = "ddraw.arrow";

    public static void Arrow([NotNull] Connection connection, Vector3 from, Vector3 to, float headSize, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_ARROW, duration, color, from, to, headSize, visibleDistance);
    }

    public static void Arrow([NotNull] BasePlayer player, Vector3 from, Vector3 to, float headSize, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Arrow(player.Connection, from, to, headSize, color, duration, visibleDistance);
    }

    public static void Arrow([NotNull] IEnumerable<BasePlayer> players, Vector3 from, Vector3 to, float headSize, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_ARROW, duration, color, from, to, headSize, visibleDistance);
    }

    public static void Arrow([NotNull] List<Connection> connections, Vector3 from, Vector3 to, float headSize, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_ARROW, duration, color, from, to, headSize, visibleDistance);
    }

    /// <summary>
    /// Render a top-down arrow at a given position.
    /// </summary>
    public static void TopDownArrow([NotNull] BasePlayer player, Vector3 pos, float yPos, Color color, float duration,
        float height = 50, float headSize = 15, float visibleDistance = float.PositiveInfinity)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        var to = new Vector3(pos.x, yPos, pos.z);
        Vector3 from = to + new Vector3(0, height, 0);

        Arrow(player, from, to, headSize, color, duration, visibleDistance);
    }

    /// <summary>
    /// Render a top-down arrow at a given position.
    /// </summary>
    public static void TopDownArrow([NotNull] IEnumerable<BasePlayer> players, Vector3 pos, float yPos, Color color, float duration,
        float height = 50, float headSize = 15, float visibleDistance = float.PositiveInfinity)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        var to = new Vector3(pos.x, yPos, pos.z);
        Vector3 from = to + new Vector3(0, height, 0);

        Arrow(players, from, to, headSize, color, duration, visibleDistance);
    }

    /// <summary>
    /// Render a top-down arrow at a given position.
    /// </summary>
    public static void TopDownArrow([NotNull] List<Connection> connections, Vector3 pos, float yPos, Color color, float duration,
        float height = 50, float headSize = 15, float visibleDistance = float.PositiveInfinity)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        var to = new Vector3(pos.x, yPos, pos.z);
        Vector3 from = to + new Vector3(0, height, 0);

        Arrow(connections, from, to, headSize, color, duration, visibleDistance);
    }
}