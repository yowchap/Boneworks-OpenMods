using HarmonyLib;
using StressLevelZero.Props;
using UnityEngine;

namespace YOWC.BetterBottles
{
    [HarmonyPatch(typeof(Prop_Health))]
    [HarmonyPatch("SPAWNBITS")]
    static class SpawnBitsPatch
    {
        private static void Prefix(Prop_Health __instance)
        {
            try
            {
                if (__instance.name.ToLower().Contains("dest_bottle"))
                {
                    __instance.min_Bits = __instance.prop_Bits.Count + __instance.prop_Hero.Count;
                    __instance.max_Bits = __instance.prop_Bits.Count + __instance.prop_Hero.Count;

                    Prop_Health[] prop_healths = __instance.GetComponentsInChildren<Prop_Health>(true);
                    for (int i = 0; i < prop_healths.Length; i++)
                    {
                        if (prop_healths[i].gameObject.name != __instance.name)
                            GameObject.Destroy(prop_healths[i]);
                    }
                }
            }
            catch { }
        }
    }
}
