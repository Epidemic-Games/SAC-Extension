using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;

namespace Oxide.Ext.SAC.Plugins
{
    internal class SACExtensionCore : SACPlugin
    {
        public static SACExtensionCore _instance;

        public SACExtensionCore() 
        {
            Name = "Super Anti-Cheat";
            Title  = "Super Anti-Cheat";
        }

        [HookMethod(nameof(Init))]
        public void Init()
        {
            _instance = this;
            AddCovalenceCommand(["sac"], nameof(SACCommand));
        }

        [HookMethod(nameof(SACCommand))]
        private void SACCommand(IPlayer player, string cmd, string[] args)
        {
        }
    }
}
