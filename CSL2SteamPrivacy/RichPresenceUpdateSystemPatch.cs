using System;
using Colossal.PSI.Steamworks;
using HarmonyLib;

namespace CSL2SteamPrivacy
{
    [HarmonyPatch(typeof(SteamworksPlatform), nameof(SteamworksPlatform.SetRichPresence),
        new Type[]{typeof(string)})]
    [HarmonyPatch(typeof(SteamworksPlatform), nameof(SteamworksPlatform.SetRichPresence),
        new Type[]{typeof(string), typeof(string)})]
    public class SetRichPresencePatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
