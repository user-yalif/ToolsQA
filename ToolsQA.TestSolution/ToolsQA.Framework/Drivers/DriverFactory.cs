namespace ToolsQA.Framework.Drivers
{
    using System;
    using ToolsQA.Framework.Drivers.Interfaces;

    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(string driverType)
        {
            return driverType switch
            {
                "Chrome" => new Chrome(),
                _ => throw new PlatformNotSupportedException($"{driverType} browser type is not supported.")
            };
        }
    }
}
