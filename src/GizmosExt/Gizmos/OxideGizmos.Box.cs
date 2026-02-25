using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render a box using lines at a given position/rotation.
/// </summary>
public static partial class OxideGizmos
{
    private const string COMMAND_BOX = "ddraw.box";

    public static void Box([NotNull] Connection connection, Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_BOX, duration, color, pos, size, rot.eulerAngles, visibleDistance, zTest);
    }

    public static void Box([NotNull] BasePlayer player, Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Box(player.Connection, pos, rot, size, color, duration, visibleDistance, zTest);
    }

    public static void Box([NotNull] IEnumerable<BasePlayer> players, Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_BOX, duration, color, pos, size, rot.eulerAngles, visibleDistance, zTest);
    }

    public static void Box([NotNull] List<Connection> connections, Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_BOX, duration, color, pos, size, rot.eulerAngles, visibleDistance, zTest);
    }

    public static void Box([NotNull] Connection connection, Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_BOX, duration, color, pos, size, rot.eulerAngles, visibleDistance, zTest);
    }

    public static void Box([NotNull] BasePlayer player, Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Box(player.Connection, pos, rot, size, color, duration, visibleDistance, zTest);
    }

    public static void Box([NotNull] IEnumerable<BasePlayer> players, Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_BOX, duration, color, pos, size, rot.eulerAngles, visibleDistance, zTest);
    }

    public static void Box([NotNull] List<Connection> connections, Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        float visibleDistance = float.PositiveInfinity, bool zTest = true)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_BOX, duration, color, pos, size, rot.eulerAngles, visibleDistance, zTest);
    }
}