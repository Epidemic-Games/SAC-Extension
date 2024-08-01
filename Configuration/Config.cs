using System;
using System.IO;
using Newtonsoft.Json;
using Oxide.Core;
using Oxide.Core.Configuration;
using Oxide.Ext.SAC.Json;
using Oxide.Ext.SAC.Logging;

namespace Oxide.Ext.SAC.Configuration
{
    public class Config : ConfigFile
    {
        Config config;

        public Config(string filename) : base(filename)
        {
            if(config != null)
                SACExtension.ExtensionLogger.Error("There are multiple SAC configuration file instances found.");

            config = this;
            LoadDefaultConfig();
        }

        public static void LoadConfig()
        {
            string configPath = Path.Combine(Interface.Oxide.InstanceDirectory, "sac.config.json");
            Config config = File.Exists(configPath) ? ConfigFile.Load<Config>(configPath) : new Config(configPath);
            config.Save();
        }

        public override void Load(string filename = null)
        {
            try
            {
                base.Load(filename);
                LoadDefaultConfig();
            }
            catch (Exception ex)
            {
                SACExtension.ExtensionLogger.Exception("Failed to load config file. Using default config.", ex);
                LoadDefaultConfig();
            }
        }

        public void LoadDefaultConfig()
        {
            debugMode = false;
            logLevel = LogLevel.Info;
        }

        // Other Settings
        [JsonProperty(PropertyName = "Debug Mode")]
        public bool debugMode { get; set; }

        [JsonProperty(PropertyName = "Log level (0 = Info, 1 = Warning, 2 = Error, 3 = Debug)")]
        public LogLevel logLevel { get; set; }

        [JsonProperty(PropertyName = "SAC Token (Visit the docs to get the token)")]
        public string token { get; set; }
    }
}
