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

        private Harmony patcher;

        public void Awake()
        {
            // Init our logging class so that we can properly log for debugging
            Log.Init(Logger);

            //Init the patcher
            patcher = new Harmony(PluginName);
            patcher.PatchAll(typeof(SoundPatcher));
        }
    }
}
