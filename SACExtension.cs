using Oxide.Core;
using Oxide.Core.Extensions;
using Oxide.Ext.SAC.Configuration;
using Oxide.Ext.SAC.Logging;
using Oxide.Ext.SAC.Plugins;
using Oxide.Game.Rust;

namespace Oxide.Ext.SAC
{
    public class SACExtension : Extension
    {
        public SACExtension(ExtensionManager manager) : base(manager) { }

        public static string _name = "Super Anti-Cheat";
        public static string _author = "Epidemic";
        public static VersionNumber _extensionVersion = new(0, 0, 1);

        // Initialise extension details
        public override string Name => _name;
        public override string Author => _author;
        public override VersionNumber Version => _extensionVersion;

        // Creating a logger so that other parts of the extension can use it
        public static ILog? ExtensionLogger;

        // Called when the extension is loaded
        public override void OnModLoad()
        {
            Config.LoadConfig();
            ExtensionLogger = new Logger(LogLevel.Info);
            Manager.RegisterPluginLoader(new SACPluginLoader());
        }
    }
}