namespace ToolsQA.Framework.Drivers
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Concurrent;
    using static ToolsQA.Framework.Settings.SettingsConfigurator;

    public static class WebDriverManager
    {
        private static string PathToDriver => AppDomain.CurrentDomain.BaseDirectory;
        private static ConcurrentDictionary<string, IWebDriver> DriversInUse { get; set; } = new ConcurrentDictionary<string, IWebDriver>();
        private static string CurrentKey => TestContext.CurrentContext.Test.ID;

        public static IWebDriver Driver
        {
            get
            {
                if (DriversInUse.ContainsKey(CurrentKey))
                {
                    return DriversInUse[CurrentKey];
                }
                else
                {
                    var testId = TestContext.CurrentContext.Test.ID;
                    var driver = new DriverFactory().GetDriver(AppSettings.Browser).SetUp(PathToDriver);

                    if (driver == null)
                    {
                        throw new NullReferenceException("WebDriver instance was not initialized.");
                    }

                    return DriversInUse[testId] = driver;
                }
            }
        }

        public static void ReleaseDriver()
        {
            if (DriversInUse.ContainsKey(CurrentKey))
            {
                DriversInUse[CurrentKey].Quit();

                if (!DriversInUse.TryRemove(CurrentKey, out _))
                {
                    throw new ArgumentNullException();
                }
            }

            if (!DriversInUse.IsEmpty)
            {
                var keys = DriversInUse.Keys;

                foreach (var key in keys)
                {
                    DriversInUse[key].Quit();

                    if (!DriversInUse.TryRemove(key, out _))
                    {
                        throw new ArgumentNullException();
                    }
                }
            }
        }
    }
}
