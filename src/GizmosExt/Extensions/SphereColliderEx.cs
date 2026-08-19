using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class SphereColliderEx
{
    extension(SphereCollider col)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = OxideGizmos.DEFAULT_ID)
        {
            OxideGizmos.Sphere(player, col.transform.position, col.radius, color, duration,
                distanceFade, zTest, entityID, id);
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = OxideGizmos.DEFAULT_ID)
        {
            OxideGizmos.Sphere(players, col.transform.position, col.radius, color, duration,
                distanceFade, zTest, entityID, id);
        }
    }
}
