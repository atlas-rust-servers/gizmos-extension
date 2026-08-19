using JetBrains.Annotations;
using UnityEngine;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class MeshColliderEx
{
    extension(MeshCollider collider)
    {
        public void DrawGizmos(BasePlayer player, float duration, Color color)
        {
            Mesh mesh = collider.sharedMesh;
            Vector3[] vertices = mesh.vertices;
            int[] triangles = mesh.triangles;

            for (int i = 0; i < triangles.Length; i += 3)
            {
                Vector3 a = vertices[triangles[i]];
                Vector3 b = vertices[triangles[i + 1]];
                Vector3 c = vertices[triangles[i + 2]];

                a = collider.transform.TransformPoint(a);
                b = collider.transform.TransformPoint(b);
                c = collider.transform.TransformPoint(c);

                OxideGizmos.Line(player, a, b, color, duration);
                OxideGizmos.Line(player, b, c, color, duration);
                OxideGizmos.Line(player, c, a, color, duration);
            }
        }

        public void DrawGizmos(IEnumerable<BasePlayer> players, float duration, Color color)
        {
            Mesh mesh = collider.sharedMesh;
            Vector3[] vertices = mesh.vertices;
            int[] triangles = mesh.triangles;

            for (int i = 0; i < triangles.Length; i += 3)
            {
                Vector3 a = vertices[triangles[i]];
                Vector3 b = vertices[triangles[i + 1]];
                Vector3 c = vertices[triangles[i + 2]];

                a = collider.transform.TransformPoint(a);
                b = collider.transform.TransformPoint(b);
                c = collider.transform.TransformPoint(c);

                OxideGizmos.Line(players, a, b, color, duration);
                OxideGizmos.Line(players, b, c, color, duration);
                OxideGizmos.Line(players, c, a, color, duration);
            }
        }
    }
}