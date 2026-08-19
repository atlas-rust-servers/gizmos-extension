using JetBrains.Annotations;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static partial class OxideGizmos
{
    internal const bool DEFAULT_DISTANCE_FADE = true;
    internal const bool DEFAULT_Z_TEST = true;
    internal const bool DEFAULT_LINE_Z_TEST = false;
    internal const string DEFAULT_ID = null;

    /// <summary>
    /// Can be used by plugins to reference gizmos between them.
    /// </summary>
    public static readonly List<IGizmosDrawer> AllGizmos = new();
}