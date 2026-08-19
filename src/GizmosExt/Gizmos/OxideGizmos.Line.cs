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

    public static void Line([NotNull] Connection connection,
        Vector3 from, Vector3 to, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_LINE, duration, color, from, to, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] BasePlayer player,
        Vector3 from, Vector3 to, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Line(player.Connection, from, to, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] IEnumerable<BasePlayer> players,
        Vector3 from, Vector3 to, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_LINE, duration, color, from, to, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] List<Connection> connections,
        Vector3 from, Vector3 to, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_LINE, duration, color, from, to, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] Connection connection,
        Vector3 from, Vector3 to, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_LINE, duration, color, from, to, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] BasePlayer player,
        Vector3 from, Vector3 to, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Line(player.Connection, from, to, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] IEnumerable<BasePlayer> players,
        Vector3 from, Vector3 to, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_LINE, duration, color, from, to, distanceFade, zTest, entityID, id);
    }

    public static void Line([NotNull] List<Connection> connections,
        Vector3 from, Vector3 to, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_LINE, duration, color, from, to, distanceFade, zTest, entityID, id);
    }
}