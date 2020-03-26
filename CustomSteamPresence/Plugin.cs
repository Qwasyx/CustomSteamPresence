using IPALogger = IPA.Logging.Logger;
using HarmonyLib;
using System.Reflection;
using IPA;

namespace CustomSteamPresence
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        public static Plugin instance;
        internal TextManager textManager;
        internal static IPALogger logger;

        [Init]
        public void Init(IPALogger _logger)
        {
            instance = this;
            logger = _logger;
            textManager = new TextManager();
            textManager.Load();
        }

        [OnStart]
        public void OnApplicationStart()
        {
            new Harmony("qwasyx.CustomSteamPresence").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
