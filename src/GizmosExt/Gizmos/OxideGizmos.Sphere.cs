using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render a sphere at a given position.
/// </summary>
public static partial class OxideGizmos
{
    private const string COMMAND_SPHERE = "ddraw.sphere";

    public static void Sphere([NotNull] Connection connection,
        Vector3 pos, float radius, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_SPHERE, duration, color, pos, radius, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] BasePlayer player,
        Vector3 pos, float radius, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Sphere(player.Connection, pos, radius, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] IEnumerable<BasePlayer> players,
        Vector3 pos, float radius, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_SPHERE, duration, color, pos, radius, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] List<Connection> connections,
        Vector3 pos, float radius, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_SPHERE, duration, color, pos, radius, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] Connection connection,
        Vector3 pos, float radius, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_SPHERE, duration, color, pos, radius, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] BasePlayer player,
        Vector3 pos, float radius, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Sphere(player.Connection, pos, radius, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] IEnumerable<BasePlayer> players,
        Vector3 pos, float radius, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_SPHERE, duration, color, pos, radius, distanceFade, zTest, entityID, id);
    }

    public static void Sphere([NotNull] List<Connection> connections,
        Vector3 pos, float radius, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = null)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_SPHERE, duration, color, pos, radius, distanceFade, zTest, entityID, id);
    }
}