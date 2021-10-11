namespace ToolsQA.Framework.Helpers.Implementations
{
    using System;
    using ToolsQA.Framework.Helpers.Interfaces;
    using ToolsQA.Framework.Settings.Enums;

    public class LoggerFactory : ILoggerFactory
    {
        public override ILoggerInstance GetLogger(LoggerType logger)
        {
            return logger switch
            {
                LoggerType.Serilog => new SerilogInstance(),
                LoggerType.Log4Net => new Log4NetInstance(),
                _ => throw new PlatformNotSupportedException($"{logger} browser type is not supported.")
            };
        }
    }
}
