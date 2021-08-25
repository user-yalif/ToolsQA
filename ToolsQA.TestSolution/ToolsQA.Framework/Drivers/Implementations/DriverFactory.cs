namespace ToolsQA.Framework.Drivers.Implementations
{
    using System;
    using ToolsQA.Framework.Drivers.Interfaces;
    using ToolsQA.Framework.Settings.Enums;

    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(BrowserType driverType)
        {
            return driverType switch
            {
                BrowserType.Chrome => new Chrome(),
                _ => throw new PlatformNotSupportedException($"{driverType} browser type is not supported.")
            };
        }
    }
}
