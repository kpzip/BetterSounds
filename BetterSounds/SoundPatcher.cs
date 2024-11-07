using EntityStates.Loader;
using HarmonyLib;
using RoR2.WwiseUtils;

namespace BetterSounds
{
    class SoundPatcher
    {
        [HarmonyPatch(typeof(LoaderMeleeAttack), "methodName")]
        [HarmonyPrefix]
        static int Patch()
        {
            return 1;
        }
    }
}