namespace ToolsQA.Framework.Drivers
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Concurrent;
    using ToolsQA.Framework.Drivers.Implementations;
    using ToolsQA.Framework.Helpers;
    using static ToolsQA.Framework.SetUp.SettingsConfigurator;

    public static class WebDriverManager
    {
        private static string PathToDriver => AppDomain.CurrentDomain.BaseDirectory;
        private static ConcurrentDictionary<string, IWebDriver> DriversInUse { get; set; } = new ConcurrentDictionary<string, IWebDriver>();
        private static string CurrentKey => TestContext.CurrentContext.Test.ID;

        public static IWebDriver Driver
        {
            get
            {
                if (!DriversInUse.ContainsKey(CurrentKey))
                {
                    var driver = new DriverFactory().GetDriver(AppSettings.Browser).SetUp(PathToDriver);

                    if (driver == null)
                    {
                        Logger.Log.Error("WebDriver instance was not created!");

                        throw new NullReferenceException("WebDriver instance was not initialized!");
                    }

                    DriversInUse[CurrentKey] = driver;

                    Logger.Log.Info("WebDriver {{ Thread Id: {0}; Session Id: {1} }} was succesfully created.", CurrentKey, ((WebDriver)driver).SessionId);
                }

                return DriversInUse[CurrentKey];
            }
        }

        public static void ReleaseDriver()
        {
            if (DriversInUse.ContainsKey(CurrentKey))
            {
                var sessionId = ((WebDriver)DriversInUse[CurrentKey]).SessionId;

                DriversInUse[CurrentKey].Quit();

                if (!DriversInUse.TryRemove(CurrentKey, out _))
                {
                    throw new ArgumentNullException();
                }

                Logger.Log.Info("WebDriver {{ Thread Id: {0}; Session Id: {1} }} was succesfully removed.", CurrentKey, sessionId);
            }
        }
    }
}
