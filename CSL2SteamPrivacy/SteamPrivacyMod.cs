using HarmonyLib;

namespace CSL2SteamPrivacy
{
    public class SteamPrivacyMod
    {
        public static void Setup()
        {
            var harmony = new Harmony("net.johnytoxic.CSL2SteamPrivacy");
            harmony.PatchAll();
        }
    }
}
