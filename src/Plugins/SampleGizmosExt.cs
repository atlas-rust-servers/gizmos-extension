using System;
using JetBrains.Annotations;
using Oxide.Core.Libraries.Covalence;
using Oxide.Ext.GizmosExt;
using UnityEngine;

namespace Oxide.Plugins;

[Info(nameof(SampleGizmosExt), "Ilovepatatos", "1.0.0")]
[Description("Sample commands to test the gizmos extensions.")]
public class SampleGizmosExt : CovalencePlugin
{
    private const float DURATION = 10f;
    private const bool DISTANCE_FADE = true;
    private const bool Z_TEST = true;
    private const float TEXT_SCALE = 2f;

#region Commands

    [UsedImplicitly]
    [Command("gizmos.line")]
    private void Line(IPlayer iPlayer, string cmd, string[] args)
    {
        if (!TryGetPlayer(iPlayer, out BasePlayer player))
            return;

        bool distanceFade = GetBool(args, 0, DISTANCE_FADE);
        bool zTest = GetBool(args, 1, Z_TEST);

        Vector3 from = player.eyes.position;

        const float distance = 10f;
        Vector3 to = from + player.eyes.HeadRay().direction * distance;

        OxideGizmos.Line(player, from, to, Color.green, DURATION, distanceFade, zTest);
    }

    [UsedImplicitly]
    [Command("gizmos.box")]
    private void Box(IPlayer iPlayer, string cmd, string[] args)
    {
        if (!TryGetPlayer(iPlayer, out BasePlayer player))
            return;

        bool distanceFade = GetBool(args, 0, DISTANCE_FADE);
        bool zTest = GetBool(args, 1, Z_TEST);

        Vector3 pos = player.transform.position;
        Quaternion rot = player.GetNetworkRotation();
        Vector3 size = Vector3.one * 3f;

        OxideGizmos.Box(player, pos, rot, size, Color.green, DURATION, distanceFade, zTest);
    }

    [UsedImplicitly]
    [Command("gizmos.sphere")]
    private void Sphere(IPlayer iPlayer, string cmd, string[] args)
    {
        if (!TryGetPlayer(iPlayer, out BasePlayer player))
            return;

        bool distanceFade = GetBool(args, 0, DISTANCE_FADE);
        bool zTest = GetBool(args, 1, Z_TEST);

        const float radius = 3f;
        Vector3 pos = player.transform.position;

        OxideGizmos.Sphere(player, pos, radius, Color.green, DURATION, distanceFade, zTest);
    }

    [UsedImplicitly]
    [Command("gizmos.arrow")]
    private void Arrow(IPlayer iPlayer, string cmd, string[] args)
    {
        if (!TryGetPlayer(iPlayer, out BasePlayer player))
            return;

        bool distanceFade = GetBool(args, 0, DISTANCE_FADE);
        bool zTest = GetBool(args, 1, Z_TEST);

        Vector3 from = player.eyes.position;

        const float distance = 10f;
        Vector3 to = from + player.eyes.HeadRay().direction * distance;

        const float headSize = 10f;
        OxideGizmos.Arrow(player, from, to, headSize, Color.green, DURATION, distanceFade, zTest);
    }

    [UsedImplicitly]
    [Command("gizmos.text")]
    private void Text(IPlayer iPlayer, string cmd, string[] args)
    {
        if (!TryGetPlayer(iPlayer, out BasePlayer player))
            return;

        float scale = GetFloat(args, 0, TEXT_SCALE);
        bool distanceFade = GetBool(args, 1, DISTANCE_FADE);
        bool zTest = GetBool(args, 2, Z_TEST);

        const string text = "<size=20>Hello World!</size>";
        Vector3 pos = player.eyes.position;

        OxideGizmos.Text(player, pos, text, Color.green, DURATION, scale, distanceFade, zTest);
    }

#endregion

#region Utility

    [MustUseReturnValue]
    [ContractAnnotation("iPlayer:null => false")]
    private static bool TryGetPlayer(IPlayer iPlayer, out BasePlayer player)
    {
        player = iPlayer.Object as BasePlayer;
        return player != null;
    }

    [MustUseReturnValue]
    private static bool HasArgs(string[] args, int index)
    {
        return args != null && args.Length > index;
    }

    [MustUseReturnValue]
    private static string GetString(string[] args, int index, string fallback = "")
    {
        return HasArgs(args, index) ? args[index] : fallback;
    }

    [MustUseReturnValue]
    private static bool GetBool(string[] args, int index, bool fallback = false)
    {
        string value = GetString(args, index);

        if (string.Equals(value, "0") || string.Equals(value, "false", StringComparison.InvariantCultureIgnoreCase))
            return false;

        if (string.Equals(value, "1") || string.Equals(value, "true", StringComparison.InvariantCultureIgnoreCase))
            return true;

        return fallback;
    }

    [MustUseReturnValue]
    private static float GetFloat(string[] args, int index, float fallback = 0)
    {
        string s = GetString(args, index);
        return float.TryParse(s, out float result) ? result : fallback;
    }

#endregion
}