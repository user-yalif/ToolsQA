namespace ToolsQA.Framework.Helpers.Interfaces
{
    public interface ILoggerInstance
    {
        ILoggerInstance SetUp();

        void Dispose();

        void Info(string message);

        void Info(string message, params object[] args);

        void Warn(string message);

        void Warn(string message, params object[] args);

        void Error(string message);

        void Error(string message, params object[] args);
    }
}
