using BepInEx;
using RoR2;
using HarmonyLib;

namespace BetterSounds
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class BetterSounds : BaseUnityPlugin
    {
        
        //Plugin Data
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "kpzip";
        public const string PluginName = "BetterSounds";
        public const string PluginVersion = "1.0.0";

        public void Awake()
        {
            // Init our logging class so that we can properly log for debugging
            Log.Init(Logger);

            Harmony.CreateAndPatchAll(typeof(Patch));

            GlobalEventManager.onCharacterDeathGlobal += GlobalEventManager_onCharacterDeathGlobal;
        }

        private void GlobalEventManager_onCharacterDeathGlobal(DamageReport report)
        {
            //make sure these are both nonnull
            if (!report.attacker || !report.attackerBody)
            {
                return;
            }

        }

        private void Update()
        {
        }
    }
}
