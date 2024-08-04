using Oxide.Core.Plugins;

namespace Oxide.Ext.SAC.Plugins
{
    internal class UICore : SACPlugin
    {
        public static UICore _instance;

        public UICore() 
        {

        }

        [HookMethod(nameof(Init))]
        private void Init()
        {
            _instance = this;
        }

        [HookMethod(nameof(DisplayOverviewUI))]
        private void DisplayOverviewUI()
        {

        }

        [HookMethod(nameof(DisplayPlayersUI))]
        private void DisplayPlayersUI()
        {

        }

        [HookMethod(nameof(DisplayPlayersUI))]
        private void DisplayReportsUI()
        {

        }

        [HookMethod(nameof(CreatePanel))]
        private void CreatePanel()
        {

        }

        [HookMethod(nameof(CreateButton))]
        private void CreateButton()
        {

        }

        [HookMethod(nameof(CreateIconButton))]
        private void CreateIconButton()
        {

        }
    }
}
