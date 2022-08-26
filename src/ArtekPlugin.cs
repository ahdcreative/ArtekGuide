namespace ArtekGuide;

using Dalamud.IoC;
using Dalamud.Plugin;
using ArtekGuide.Base;

internal class ArtekPlugin : IDalamudPlugin
{
    /// <summary> 
    ///     The plugin name, fetched from PStrings.
    /// </summary>
    public string Name => PStrings.pluginName;

    /// <summary>
    ///     The plugin's main entry point.
    /// </summary>
    public ArtekPlugin([RequiredVersion("1.0")] DalamudPluginInterface pluginInterface)
    {
        pluginInterface.Create<PluginService>();
        PluginService.Initialize();

#if !DEBUG
        PluginService.ResourceManager.Update();
#endif

    }

    /// <summary>
    ///     Handles disposing of all resources used by the plugin.
    /// </summary>
    public void Dispose() => PluginService.Dispose();
}
