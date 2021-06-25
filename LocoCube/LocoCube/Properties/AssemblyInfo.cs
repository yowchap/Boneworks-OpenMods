using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(YOWC.LocoCube.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(YOWC.LocoCube.BuildInfo.Company)]
[assembly: AssemblyProduct(YOWC.LocoCube.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + YOWC.LocoCube.BuildInfo.Author)]
[assembly: AssemblyTrademark(YOWC.LocoCube.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(YOWC.LocoCube.BuildInfo.Version)]
[assembly: AssemblyFileVersion(YOWC.LocoCube.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(YOWC.LocoCube.Main), YOWC.LocoCube.BuildInfo.Name, YOWC.LocoCube.BuildInfo.Version, YOWC.LocoCube.BuildInfo.Author, YOWC.LocoCube.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONEWORKS")]