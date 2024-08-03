using Oxide.Core.Plugins;

namespace Oxide.Ext.SAC.Plugins
{
    public class SACPlugin : CSPlugin
    {
        protected SACPlugin() 
        {
            Author = SACExtension._author;
            Version = SACExtension._extensionVersion;
        }
    }
}
