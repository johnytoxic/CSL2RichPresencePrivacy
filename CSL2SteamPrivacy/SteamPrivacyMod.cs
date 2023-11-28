using BepInEx;

namespace CSL2SteamPrivacy
{
    [BepInPlugin("net.johnytoxic.CSL2SteamPrivacy", "Steam Privacy Mod", "1.0.0")]
    public class SteamPrivacyMod : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new HarmonyLib.Harmony("net.johnytoxic.CSL2SteamPrivacy");
            harmony.PatchAll();
        }
    }
}
