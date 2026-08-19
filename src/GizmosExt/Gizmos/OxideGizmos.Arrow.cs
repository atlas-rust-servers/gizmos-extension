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
    private const float DEFAULT_HEIGHT = 50f;
    private const float DEFAULT_HEAD_SIZE = 15f;

    public static void Arrow([NotNull] Connection connection,
        Vector3 from, Vector3 to, float headSize, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_ARROW, duration, color, from, to, headSize, distanceFade, zTest, entityID, id);
    }

    public static void Arrow([NotNull] BasePlayer player,
        Vector3 from, Vector3 to, float headSize, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Arrow(player.Connection, from, to, headSize, color, duration, distanceFade, zTest, entityID, id);
    }

    public static void Arrow([NotNull] IEnumerable<BasePlayer> players,
        Vector3 from, Vector3 to, float headSize, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_ARROW, duration, color, from, to, headSize, distanceFade, zTest, entityID, id);
    }

    public static void Arrow([NotNull] List<Connection> connections,
        Vector3 from, Vector3 to, float headSize, Color color, float duration,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_ARROW, duration, color, from, to, headSize, distanceFade, zTest, entityID, id);
    }

    /// <summary>
    /// Render a top-down arrow at a given position.
    /// </summary>
    public static void TopDownArrow([NotNull] BasePlayer player,
        Vector3 pos, float yPos, Color color, float duration, float height = DEFAULT_HEIGHT, float headSize = DEFAULT_HEAD_SIZE,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        var to = new Vector3(pos.x, yPos, pos.z);
        Vector3 from = to + new Vector3(0, height, 0);

        Arrow(player, from, to, headSize, color, duration, distanceFade, zTest, entityID, id);
    }

    /// <summary>
    /// Render a top-down arrow at a given position.
    /// </summary>
    public static void TopDownArrow([NotNull] IEnumerable<BasePlayer> players,
        Vector3 pos, float yPos, Color color, float duration, float height = DEFAULT_HEIGHT, float headSize = DEFAULT_HEAD_SIZE,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        var to = new Vector3(pos.x, yPos, pos.z);
        Vector3 from = to + new Vector3(0, height, 0);

        Arrow(players, from, to, headSize, color, duration, distanceFade, zTest, entityID, id);
    }

    /// <summary>
    /// Render a top-down arrow at a given position.
    /// </summary>
    public static void TopDownArrow([NotNull] List<Connection> connections,
        Vector3 pos, float yPos, Color color, float duration, float height = DEFAULT_HEIGHT, float headSize = DEFAULT_HEAD_SIZE,
        bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        var to = new Vector3(pos.x, yPos, pos.z);
        Vector3 from = to + new Vector3(0, height, 0);

        Arrow(connections, from, to, headSize, color, duration, distanceFade, zTest, entityID, id);
    }
}