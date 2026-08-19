using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class ColliderEx
{
    extension(Collider col)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = null)
        {
            switch (col)
            {
                case SphereCollider sphere:
                    sphere.DrawGizmos(player, duration, color, distanceFade, zTest, entityID, id);
                    break;
                case BoxCollider box:
                    box.DrawGizmos(player, duration, color, distanceFade, zTest, entityID, id);
                    break;
                case CapsuleCollider capsule:
                    capsule.DrawGizmos(player, duration, color, distanceFade, zTest, entityID, id);
                    break;
                case MeshCollider mesh:
                    mesh.DrawGizmos(player, duration, color, distanceFade, zTest, entityID, id);
                    break;
            }
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color,
            bool distanceFade = OxideGizmos.DEFAULT_DISTANCE_FADE, bool zTest = OxideGizmos.DEFAULT_Z_TEST,
            NetworkableId entityID = default, string id = null)
        {
            switch (col)
            {
                case SphereCollider sphere:
                    sphere.DrawGizmos(players, duration, color, distanceFade, zTest, entityID, id);
                    break;
                case BoxCollider box:
                    box.DrawGizmos(players, duration, color, distanceFade, zTest, entityID, id);
                    break;
                case CapsuleCollider capsule:
                    capsule.DrawGizmos(players, duration, color, distanceFade, zTest, entityID, id);
                    break;
                case MeshCollider mesh:
                    mesh.DrawGizmos(players, duration, color, distanceFade, zTest, entityID, id);
                    break;
            }
        }
    }
}
