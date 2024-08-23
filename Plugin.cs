using BepInEx;

namespace DummyMod
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        //Your plugin guid
        public const string PLUGIN_GUID = "YourPluginName";
        //Your plugin name
        public const string PLUGIN_NAME = "YourPluginGUID";
        //A plugin version higher than your latest version.
        public const string PLUGIN_VERSION = "99.0";

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogWarning($"Plugin {PluginInfo.PLUGIN_NAME} ({PluginInfo.PLUGIN_GUID}) is no longer functional and will not be updated. Please remove this plugin manually or unsubscribe in Modkist if the plugin is still listed.");
        }
    }
}
