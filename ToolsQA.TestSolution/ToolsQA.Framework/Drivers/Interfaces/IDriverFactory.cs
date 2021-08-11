namespace ToolsQA.Framework.Drivers.Interfaces
{
    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(string driverType);
    }
}
