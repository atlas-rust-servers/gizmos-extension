using JetBrains.Annotations;
using Network;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

/// <summary>
/// Render a text at a given position.
/// </summary>
public static partial class OxideGizmos
{
    private const string COMMAND_TEXT = "ddraw.text";
    private const float DEFAULT_SCALE = 1f;

    public static void Text([NotNull] Connection connection,
        Vector3 pos, string text, Color color, float duration,
        float scale = DEFAULT_SCALE, bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connection == null)
            throw new ArgumentNullException(nameof(connection));

        SendHandler.Enqueue(connection, COMMAND_TEXT, duration, color, pos, text, distanceFade, zTest, scale, entityID, id);
    }

    public static void Text([NotNull] BasePlayer player,
        Vector3 pos, string text, Color color, float duration,
        float scale = DEFAULT_SCALE, bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (player == null)
            throw new ArgumentNullException(nameof(player));

        Text(player.Connection, pos, text, color, duration, scale, distanceFade, zTest, entityID, id);
    }

    public static void Text([NotNull] IEnumerable<BasePlayer> players,
        Vector3 pos, string text, Color color, float duration,
        float scale = DEFAULT_SCALE, bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (players == null)
            throw new ArgumentNullException(nameof(players));

        SendHandler.Enqueue(players, COMMAND_TEXT, duration, color, pos, text, distanceFade, zTest, scale, entityID, id);
    }

    public static void Text([NotNull] List<Connection> connections,
        Vector3 pos, string text, Color color, float duration,
        float scale = DEFAULT_SCALE, bool distanceFade = DEFAULT_DISTANCE_FADE, bool zTest = DEFAULT_LINE_Z_TEST,
        NetworkableId entityID = default, string id = DEFAULT_ID)
    {
        if (connections == null)
            throw new ArgumentNullException(nameof(connections));

        SendHandler.Enqueue(connections, COMMAND_TEXT, duration, color, pos, text, distanceFade, zTest, scale, entityID, id);
    }
}