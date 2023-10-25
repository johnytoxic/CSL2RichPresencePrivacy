using Colossal.PSI.Steamworks;
using HarmonyLib;

namespace CSL2SteamPrivacy
{
    [HarmonyPatch(typeof(SteamworksPlatform), nameof(SteamworksPlatform.SetRichPresence))]
    public class SetRichPresencePatch
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
