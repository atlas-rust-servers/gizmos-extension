using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class BoundsEx
{
    extension(Bounds bounds)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color)
        {
            OxideGizmos.Bounds(player, bounds, color, duration);
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color)
        {
            OxideGizmos.Bounds(players, bounds, color, duration);
        }
    }
}
