using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render a bounding box using lines at a given bounds.
/// </summary>
public static partial class OxideGizmos
{
    public static void Bounds([NotNull] Connection connection,
        Bounds bounds, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        Box(connection, bounds.center, Quaternion.identity, bounds.size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] BasePlayer player,
        Bounds bounds, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Bounds(player.Connection, bounds, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] IEnumerable<BasePlayer> players,
        Bounds bounds, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        Box(players, bounds.center, Quaternion.identity, bounds.size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] List<Connection> connections,
        Bounds bounds, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        Box(connections, bounds.center, Quaternion.identity, bounds.size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] Connection connection,
        Bounds bounds, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        Box(connection, bounds.center, Quaternion.identity, bounds.size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] BasePlayer player,
        Bounds bounds, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Bounds(player.Connection, bounds, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] IEnumerable<BasePlayer> players,
        Bounds bounds, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        Box(players, bounds.center, Quaternion.identity, bounds.size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Bounds([NotNull] List<Connection> connections,
        Bounds bounds, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        Box(connections, bounds.center, Quaternion.identity, bounds.size, color, duration, distanceFade, zTest, entityID, id);
    }
}