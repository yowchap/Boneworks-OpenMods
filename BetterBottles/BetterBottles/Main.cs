using HarmonyLib;
using MelonLoader;
using ModThatIsNotMod;
using StressLevelZero.Interaction;
using StressLevelZero.Props;
using System.Collections;
using UnityEngine;

namespace YOWC.BetterBottles
{
    public static class BuildInfo
    {
        public const string Name = "Better Bottles"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "YOWChap"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            Hooking.CreateHook(typeof(Prop_Health).GetMethod("DESTROYED", AccessTools.all), typeof(Main).GetMethod("OnPropDestroyed", AccessTools.all));
        }


        private static void OnPropDestroyed(Prop_Health __instance)
        {
            try
            {
                if (__instance.name.ToLower().Contains("dest_bottle") && __instance.prop_Hero.Count > 0)
                {
                    // Max distance is small so if you throw/shoot a bottle it won't be grabbed
                    if ((Player.rightHand.palmPositionTransform.position - __instance.prop_Hero[0].transform.position).sqrMagnitude <= 0.02f)
                        MelonCoroutines.Start(DelayedGrab(__instance.prop_Hero[0], Player.rightHand));
                    else if ((Player.leftHand.palmPositionTransform.position - __instance.prop_Hero[0].transform.position).sqrMagnitude <= 0.02f)
                        MelonCoroutines.Start(DelayedGrab(__instance.prop_Hero[0], Player.leftHand));
                }
            }
            catch { }
        }

        private static IEnumerator DelayedGrab(GameObject go, Hand hand)
        {
            yield return new WaitForEndOfFrame(); // It's been a long time since I made this mod so I don't fully remember why it needs to wait a frame, I just know it's necessary

            // Enable the stabby bottle part and force the player to grab it
            go.SetActive(true);
            go.transform.parent = null;
            go.GetComponentInChildren<Grip>().Snatch(hand, true);
        }
    }
}
