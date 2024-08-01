using Oxide.Core;
using Oxide.Core.Extensions;
using Oxide.Ext.SAC.Logging;

namespace Oxide.Ext.SAC
{
    public class SACExtension : Extension
    {
        public SACExtension(ExtensionManager manager) : base(manager) { }

        // Initialise extension details
        public override string Name => "Super Anti-Cheat";
        public override string Author => "Epidemic";
        public override VersionNumber Version => new(0, 0, 1);

        // Creating a logger so that other parts of the extension can use it
        public static ILog? ExtensionLogger;

        // Called when the extension is loaded
        public override void Load()
        {
            ExtensionLogger = new Logger(LogLevel.Info);
        }
    }
}