using Oxide.Core;
using System;

namespace Oxide.Ext.SAC.Logging
{
    internal class Logger : ILog
    {
        private LogLevel _logLevel;

        public Logger(LogLevel initialLogLevel)
        {
            SetLogLevel(initialLogLevel);
        }

        private void SetLogLevel(LogLevel levelToSet) => _logLevel = levelToSet;

        private void SendMessage(LogLevel logLevel, string message, Exception exception = null)
        {
            switch (logLevel)
            {
                case LogLevel.Info:
                    Interface.Oxide.LogInfo(message);
                    break;

                case LogLevel.Warning:
                    Interface.Oxide.LogWarning(message);
                    break;

                case LogLevel.Error:
                    Interface.Oxide.LogError(message);
                    break;

                case LogLevel.Debug:
                    Interface.Oxide.LogDebug(message);
                    break;

                case LogLevel.Exception:
                    Interface.Oxide.LogException(message, exception);
                    break;
            }
        }

        public void Info(string message) => SendMessage(LogLevel.Info, message);

        public void Warning(string message) => SendMessage(LogLevel.Warning, message);

        public void Error(string message) => SendMessage(LogLevel.Error, message);

        public void Debug(string message) => SendMessage(LogLevel.Debug, message);

        public void Exception(string message, Exception exception) => SendMessage(LogLevel.Exception, message, exception);
    }
}
