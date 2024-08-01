using Oxide.Core;
using Oxide.Core.Extensions;

namespace Oxide.Ext.SAC
{
    public class SACExtension : Extension
    {
        public SACExtension(ExtensionManager manager) : base(manager) { }

        // Initialise extension details
        public override string Name => "Super Anti-Cheat";
        public override string Author => "Epidemic";
        public override VersionNumber Version => new(0, 0, 1);

        // Called when the extension is loaded
        public override void Load()
        {
        }
    }
}