namespace ToolsQA.Framework.Drivers.Implementations
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using ToolsQA.Framework.Drivers.Interfaces;

    public class Chrome : IDriver
    {
        private static ChromeOptions GetChromeOptions(string downloadPath)
        {
            ChromeOptions options = new();

            //options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--no-sandbox");

            // To disable popups for password saving
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);

            if (!string.IsNullOrEmpty(downloadPath))
            {
                options.AddUserProfilePreference("download.default_directory", downloadPath);
            }

            return options;
        }

        public IWebDriver SetUp(string pathToDriver, string downloadPath) =>
            new ChromeDriver(pathToDriver, GetChromeOptions(downloadPath), TimeSpan.FromMinutes(3));
    }
}
