using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class CapsuleColliderEx
{
    extension(CapsuleCollider col)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = null)
        {
            Transform transform = col.transform;
            OxideGizmos.Capsule(player, transform.position, transform.rotation.eulerAngles, col.radius, col.height, color, duration,
                distanceFade, zTest, entityID, id);
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = null)
        {
            Transform transform = col.transform;
            OxideGizmos.Capsule(players, transform.position, transform.rotation.eulerAngles, col.radius, col.height, color, duration,
                distanceFade, zTest, entityID, id);
        }
    }
}
