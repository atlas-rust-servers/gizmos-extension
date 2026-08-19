using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class SphereColliderEx
{
    extension(SphereCollider col)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color)
        {
            OxideGizmos.Sphere(player, col.transform.position, col.radius, color, duration);
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color)
        {
            OxideGizmos.Sphere(players, col.transform.position, col.radius, color, duration);
        }
    }
}