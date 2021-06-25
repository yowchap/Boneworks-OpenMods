using MelonLoader;
using ModThatIsNotMod;
using StressLevelZero.Interaction;
using StressLevelZero.Props.Weapons;
using UnityEngine;

namespace YOWC.NotGoldenMags
{
    public static class BuildInfo
    {
        public const string Name = "Not Golden Mags"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "YOWChap"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.1"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class NotGoldenMagsMod : MelonMod
    {
        private float timeBetweenMagChecks = 0.1f;
        private float timeToCheckMags;


        // Disclaimer: I made this before I really knew about harmony patching
        // Resetting the mag whenever you grab one would be MUCH better than this
        // I didn't feel like changing it though ¯\_(ツ)_/¯
        public override void OnUpdate()
        {
            if (Time.time >= timeToCheckMags)
            {
                ResetMag(Player.leftHand);
                ResetMag(Player.rightHand);

                timeToCheckMags = Time.time + timeBetweenMagChecks;
            }
        }

        private void ResetMag(Hand hand)
        {
            GameObject magGO = Player.GetObjectInHand(hand);
            if (magGO != null)
            {
                Magazine mag = magGO.GetComponent<Magazine>();
                if (mag == null)
                    mag = magGO.GetComponentInParent<Magazine>();

                if (mag != null)
                    mag.ResetMagazine();
            }
        }
    }
}
