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
        }
    }
}
