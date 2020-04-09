using UnityEngine;
using HarmonyLib;
using GadgetCore.API;

namespace Softcore.Patches
{
    [HarmonyPatch(typeof(GameScript))]
    [HarmonyPatch("EraseCharacter")]
    [HarmonyGadget("Softcore")]
    public static class Patch_GameScript_EraseCharacter
    {
        [HarmonyPrefix]
        [HarmonyPriority(Priority.Low)]
        public static bool Prefix(int a)
        {
            MonoBehaviour.print("EraseCharacter() (Patched)");
            PreviewLabs.PlayerPrefs.SetInt(a + "hp", 1);
            return false;
        }
    }
}