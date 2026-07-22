#if CARBON

using API.Assembly;
using JetBrains.Annotations;

namespace Oxide.Ext.GizmosExt;

[UsedImplicitly]
public class CarbonExtension : ICarbonExtension
{
    void ICarbonAddon.Awake(EventArgs args) { }

    void ICarbonAddon.OnLoaded(EventArgs args)
    {
        SendHandler.Initialize();
    }

    void ICarbonAddon.OnUnloaded(EventArgs args)
    {
        SendHandler.Shutdown();
    }
}

#endif