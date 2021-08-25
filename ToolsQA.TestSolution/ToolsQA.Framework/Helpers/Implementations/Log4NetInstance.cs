namespace ToolsQA.Framework.Helpers.Implementations
{
    using log4net;
    using log4net.Config;
    using System;
    using System.IO;
    using System.Reflection;
    using ToolsQA.Framework.Helpers.Interfaces;

    public class Log4NetInstance : ILoggerInstance
    {
        public ILog Logger { get; set; } = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ILoggerInstance SetUp()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetExecutingAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo(@"SettingsFiles\log4net.config"));
            
            Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            Logger.Info("Log4Net instance was successfully created.");

            return this;
        }

        public void Info(string message)
        {
            Logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            Logger.Info(string.Format(message, args));
        }

        public void Warn(string message)
        {
            Logger.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            Logger.Warn(string.Format(message, args));
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            Logger.Error(string.Format(message, args));
        }

        public void Dispose() => LogManager.Flush(TimeSpan.FromMilliseconds(500).Milliseconds);
    }
}
