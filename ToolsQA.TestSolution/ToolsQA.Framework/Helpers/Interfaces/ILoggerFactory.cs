namespace ToolsQA.Framework.Helpers.Interfaces
{
    using ToolsQA.Framework.Settings.Enums;

    public abstract class ILoggerFactory
    {
        public abstract ILoggerInstance GetLogger(LoggerType logger);
    }
}
