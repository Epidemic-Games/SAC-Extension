using System;

namespace Oxide.Ext.SAC.Logging
{
    public interface ILog
    {
        void Info(string message);

        void Warning(string message);

        void Error(string message);

        void Debug(string message);

        void Exception(string message, Exception exception);
    }
}
