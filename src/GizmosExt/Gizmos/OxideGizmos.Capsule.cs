using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render a capsule at a given position/rotation.
/// </summary>
public static partial class OxideGizmos
{
    private const string COMMAND_CAPSULE = "ddraw.capsule";

    public static void Capsule([NotNull] Connection connection, Vector3 pos, Vector3 rot, float radius, float height, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_CAPSULE, duration, color, pos, rot, radius, height, visibleDistance);
    }

    public static void Capsule(BasePlayer player, Vector3 pos, Vector3 rot, float radius, float height, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Capsule(player.Connection, pos, rot, radius, height, color, duration, visibleDistance);
    }

    public static void Capsule([NotNull] IEnumerable<BasePlayer> players, Vector3 pos, Vector3 rot, float radius, float height, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_CAPSULE, duration, color, pos, rot, radius, height, visibleDistance);
    }

    public static void Capsule([NotNull] List<Connection> connections, Vector3 pos, Vector3 rot, float radius, float height, Color color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_CAPSULE, duration, color, pos, rot, radius, height, visibleDistance);
    }

    public static void Capsule([NotNull] Connection connection, Vector3 pos, Vector3 rot, float radius, float height, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_CAPSULE, duration, color, pos, rot, radius, height, visibleDistance);
    }

    public static void Capsule(BasePlayer player, Vector3 pos, Vector3 rot, float radius, float height, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Capsule(player.Connection, pos, rot, radius, height, color, duration, visibleDistance);
    }

    public static void Capsule([NotNull] IEnumerable<BasePlayer> players, Vector3 pos, Vector3 rot, float radius, float height, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_CAPSULE, duration, color, pos, rot, radius, height, visibleDistance);
    }

    public static void Capsule([NotNull] List<Connection> connections, Vector3 pos, Vector3 rot, float radius, float height, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_CAPSULE, duration, color, pos, rot, radius, height, visibleDistance);
    }
}