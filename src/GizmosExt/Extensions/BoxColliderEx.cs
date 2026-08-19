using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class BoxColliderEx
{
    extension(BoxCollider col)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = null)
        {
            OxideGizmos.Box(player, col.transform.position, col.transform.rotation, col.size, color, duration,
                distanceFade, zTest, entityID, id);
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = null)
        {
            OxideGizmos.Box(players, col.transform.position, col.transform.rotation, col.size, color, duration,
                distanceFade, zTest, entityID, id);
        }
    }
}
