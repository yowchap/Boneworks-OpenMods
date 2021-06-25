using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(YOWC.NotGoldenMags.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(YOWC.NotGoldenMags.BuildInfo.Company)]
[assembly: AssemblyProduct(YOWC.NotGoldenMags.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + YOWC.NotGoldenMags.BuildInfo.Author)]
[assembly: AssemblyTrademark(YOWC.NotGoldenMags.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(YOWC.NotGoldenMags.BuildInfo.Version)]
[assembly: AssemblyFileVersion(YOWC.NotGoldenMags.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(YOWC.NotGoldenMags.NotGoldenMagsMod), YOWC.NotGoldenMags.BuildInfo.Name, YOWC.NotGoldenMags.BuildInfo.Version, YOWC.NotGoldenMags.BuildInfo.Author, YOWC.NotGoldenMags.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONEWORKS")]