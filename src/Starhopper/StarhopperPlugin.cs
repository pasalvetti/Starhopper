using BepInEx;
using JetBrains.Annotations;
using SpaceWarp;
using SpaceWarp.API.Mods;

namespace Starhopper;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(SpaceWarpPlugin.ModGuid, SpaceWarpPlugin.ModVer)]
public class StarhopperPlugin : BaseSpaceWarpPlugin
{
    // These are useful in case some other mod wants to add a dependency to this one
    [PublicAPI] public const string ModGuid = MyPluginInfo.PLUGIN_GUID;
    [PublicAPI] public const string ModName = MyPluginInfo.PLUGIN_NAME;
    [PublicAPI] public const string ModVer = MyPluginInfo.PLUGIN_VERSION;

    // Singleton instance of the plugin class
    public static StarhopperPlugin Instance { get; set; }

    public static string Path { get; private set; }
    public override void OnPreInitialized()
    {
        base.OnPreInitialized();
        Path = PluginFolderPath;
    }

    /// <summary>
    /// Runs when the mod is first initialized.
    /// </summary>
    public override void OnInitialized()
    {
        base.OnInitialized();

        Instance = this;
    }
}
