using HarmonyLib;

namespace BetterSounds
{
    class SoundPatcher
    {
        [HarmonyPatch(typeof(Patch), "methodName")]
        [HarmonyPrefix]
        static int Patch()
        {
            return 1;
        }
    }
}