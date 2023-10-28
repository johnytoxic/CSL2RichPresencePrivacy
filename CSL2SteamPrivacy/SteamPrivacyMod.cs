using MelonLoader;

namespace CSL2SteamPrivacy
{
    public class SteamPrivacyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            var harmony = new HarmonyLib.Harmony("net.johnytoxic.CSL2SteamPrivacy");
            harmony.PatchAll();
        }
    }
}
