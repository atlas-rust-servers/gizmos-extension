using JetBrains.Annotations;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static partial class OxideGizmos
{
    private const bool DEFAULT_DISTANCE_FADE = true;
    private const bool DEFAULT_Z_TEST = true;
    private const bool DEFAULT_LINE_Z_TEST = false;

    /// <summary>
    /// Can be used by plugins to reference gizmos between them.
    /// </summary>
    public static readonly List<IGizmosDrawer> AllGizmos = new();
}