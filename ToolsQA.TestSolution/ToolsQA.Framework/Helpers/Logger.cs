namespace ToolsQA.Framework.Helpers
{
    using ToolsQA.Framework.Helpers.Implementations;
    using ToolsQA.Framework.Helpers.Interfaces;
    using static ToolsQA.Framework.SetUp.SettingsConfigurator;

    public class Logger
    {
        private static ILoggerInstance _loggerInstance;

        public static ILoggerInstance Log
        {
            get
            {
                if (_loggerInstance == null)
                {
                    return _loggerInstance ??= new LoggerFactory().GetLogger(AppSettings.Logger).SetUp();
                }
                else
                {
                    return _loggerInstance;
                }
            }
        }
    }
}
