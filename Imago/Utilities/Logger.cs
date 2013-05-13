using log4net;
using System;
using System.Diagnostics;


namespace Imago.Utilities
{
    public class Logger
    {
        private static readonly ILog log = LogManager.GetLogger("RollingFileAppender");

        /// <summary>
        /// Logs 'Message' as an Info entry
        /// </summary>
        public static void Info(string message)
        {
            var callingFunctionName = (new StackTrace()).GetFrame(1).GetMethod().Name;
            log.Logger.Log(typeof(Logger), log4net.Core.Level.Info, String.Format(".{0}: {1}", callingFunctionName, message), null);
        }

        /// <summary>
        /// Logs 'Message' as a Debug entry
        /// </summary>
        public static void Debug(string message)
        {
            var callingFunctionName = (new StackTrace()).GetFrame(1).GetMethod().Name;
            log.Logger.Log(typeof(Logger), log4net.Core.Level.Debug, String.Format(".{0}: {1}", callingFunctionName, message), null);
        }

        /// <summary>
        /// Logs 'Message' as an Error entry
        /// </summary>
        public static void Error(string message)
        {
            var callingFunctionName = (new StackTrace()).GetFrame(1).GetMethod().Name;
            log.Logger.Log(typeof(Logger), log4net.Core.Level.Error, String.Format(".{0}: {1}", callingFunctionName, message), null);
        }
    }
}