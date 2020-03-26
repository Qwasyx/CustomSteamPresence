using HarmonyLib;
using Steamworks;

namespace CustomSteamPresence.HarmonyPatches
{
    [HarmonyPatch(typeof(SteamRichPresencePlatformHandler))]
    [HarmonyPatch("SetPresence")]
    class SteamRichPresencePlatformHandlerSetPresence
    {
        static void Postfix()
        {
            string text = Plugin.instance.textManager.GetRandomText();

            Plugin.logger.Info("setting the steam presence to '" + text + "'");

            SteamFriends.SetRichPresence("steam_display", "#StatusWithMessage");
            SteamFriends.SetRichPresence("StatusMessage", text);        }
    }
}
