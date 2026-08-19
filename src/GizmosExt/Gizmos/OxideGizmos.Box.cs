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

    public static void Box([NotNull] Connection connection,
        Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_BOX, duration, color, pos, size.ToString(), rot.eulerAngles, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] BasePlayer player,
        Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Box(player.Connection, pos, rot, size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] IEnumerable<BasePlayer> players,
        Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_BOX, duration, color, pos, size.ToString(), rot.eulerAngles, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] List<Connection> connections,
        Vector3 pos, Quaternion rot, Vector3 size, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_BOX, duration, color, pos, size.ToString(), rot.eulerAngles, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] Connection connection,
        Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_BOX, duration, color, pos, size.ToString(), rot.eulerAngles, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] BasePlayer player,
        Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Box(player.Connection, pos, rot, size, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] IEnumerable<BasePlayer> players,
        Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_BOX, duration, color, pos, size.ToString(), rot.eulerAngles, distanceFade, zTest, entityID, id);
    }

    public static void Box([NotNull] List<Connection> connections,
        Vector3 pos, Quaternion rot, Vector3 size, Vector3 color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_BOX, duration, color, pos, size.ToString(), rot.eulerAngles, distanceFade, zTest, entityID, id);
    }
}