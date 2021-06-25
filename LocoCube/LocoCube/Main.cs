using MelonLoader;
using UnityEngine;

namespace YOWC.LocoCube
{
    public static class BuildInfo
    {
        public const string Name = "LocoCube"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "YOWChap"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class Main : MelonMod
    {
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            GameObject feet = GameObject.Find("[RigManager (Default Brett)]").transform.Find("[PhysicsRig]/Feet").gameObject;
            SphereCollider locoSphere = feet.GetComponent<SphereCollider>();
            BoxCollider locoCube = feet.AddComponent<BoxCollider>();
            locoCube.size = Vector3.one * locoSphere.radius * 2f;
            locoCube.material = locoSphere.material;
            locoSphere.enabled = false;
        }
    }
}
