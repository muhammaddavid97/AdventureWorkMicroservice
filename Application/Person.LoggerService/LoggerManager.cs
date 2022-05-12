using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Contracts;
using NLog; 

namespace Person.LoggerService
{
    public class LoggerManager : ILoggerManager
    {

        // akses with NLOG interface
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        // constructor
        public LoggerManager()
        {
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
