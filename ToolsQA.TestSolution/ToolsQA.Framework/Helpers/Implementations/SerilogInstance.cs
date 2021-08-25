namespace ToolsQA.Framework.Helpers.Implementations
{
    using Serilog;
    using Serilog.Events;
    using ToolsQA.Framework.Helpers.Interfaces;

    public class SerilogInstance : ILoggerInstance
    {
        private ILogger Logger { get; set; }

        public ILoggerInstance SetUp()
        {
            this.Logger = new LoggerConfiguration()
                // TODO: Implement logger configuration from file appsettings.json
                //.ReadFrom.Configuration(configuration)
                .Enrich.FromLogContext()
                .Enrich.WithThreadId()
                .MinimumLevel.Information()
                .WriteTo.Console(outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] [{ThreadId}] [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .WriteTo.File(@"ToolsQaLogs\ToolsQaLogs_.log",
                              restrictedToMinimumLevel: LogEventLevel.Information,
                              outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] [{ThreadId}] [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                              rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Logger.Information("Serilog instance was succesfully created.");

            return this;
        }

        public void Info(string message)
        {
            Logger.Information(message);
        }

        public void Info(string message, params object[] args)
        {
            Logger.Information(message, args);
        }

        public void Warn(string message)
        {
            Logger.Warning(message);
        }

        public void Warn(string message, params object[] args)
        {
            Logger.Warning(message, args);
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            Logger.Error(message, args);
        }

        public void Dispose() => Log.CloseAndFlush();
    }
}
