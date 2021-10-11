namespace ToolsQA.Framework.Drivers.Interfaces
{
    using ToolsQA.Framework.Settings.Enums;

    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(BrowserType driverType);
    }
}
