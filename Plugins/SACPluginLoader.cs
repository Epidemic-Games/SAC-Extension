using System;
using Oxide.Game.Rust;

namespace Oxide.Ext.SAC.Plugins
{
    public class SACPluginLoader : RustPluginLoader
    {
        public override Type[] CorePlugins => new[] { typeof(SACExtensionCore), typeof(UICore) };
    }
}
