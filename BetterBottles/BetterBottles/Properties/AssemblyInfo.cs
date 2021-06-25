using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(YOWC.BetterBottles.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(YOWC.BetterBottles.BuildInfo.Company)]
[assembly: AssemblyProduct(YOWC.BetterBottles.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + YOWC.BetterBottles.BuildInfo.Author)]
[assembly: AssemblyTrademark(YOWC.BetterBottles.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(YOWC.BetterBottles.BuildInfo.Version)]
[assembly: AssemblyFileVersion(YOWC.BetterBottles.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(YOWC.BetterBottles.Main), YOWC.BetterBottles.BuildInfo.Name, YOWC.BetterBottles.BuildInfo.Version, YOWC.BetterBottles.BuildInfo.Author, YOWC.BetterBottles.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONEWORKS")]