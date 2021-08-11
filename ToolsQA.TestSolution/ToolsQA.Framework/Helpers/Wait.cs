namespace ToolsQA.Framework.Helpers
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
    using ToolsQA.Framework.Drivers;
    using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

    public static class Wait
    {
        private static TimeSpan DefaultTimeout { get; } = TimeSpan.FromSeconds(120);

        private static TimeSpan SleepInterval { get; } = TimeSpan.FromMilliseconds(1000);

        private static WebDriverWait WebDriverWait =>
            new(new SystemClock(), WebDriverManager.Driver, DefaultTimeout, SleepInterval);

        private static WebDriverWait WithTimeout(this WebDriverWait webDriverWait, int? seconds)
        {
            if (seconds.HasValue)
            {
                webDriverWait.Timeout = TimeSpan.FromSeconds(seconds.Value);
            }

            return webDriverWait;
        }

        private static Func<IWebDriver, bool> IsElementAppeared(By pathToElement)
        {
            return webDriver =>
            {
                try
                {
                    webDriver.FindElement(pathToElement);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }

        private static Func<IWebDriver, bool> IsElementDisappeared(By pathToElement)
        {
            return webDriver =>
            {
                try
                {
                    webDriver.FindElement(pathToElement);
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            };
        }

        public static bool WaitUntilElementToBeEnabled(this IWebElement element, int? timeout = null) =>
            WebDriverWait.WithTimeout(timeout).Until((driver) => element.Enabled);

        public static bool WaitUntilElementToBeDisplayed(this IWebElement element, int? timeout = null) =>
            WebDriverWait.WithTimeout(timeout).Until((driver) => element.Displayed);

        public static IWebElement WaitUntilElementToBeClickable(this IWebElement element, int? timeout = null) =>
            WebDriverWait.WithTimeout(timeout).Until(ExpectedConditions.ElementToBeClickable(element));

        public static IAlert WaitUntilAlertIsDisplayed(int? timeout = null) =>
            WebDriverWait.WithTimeout(timeout).Until(ExpectedConditions.AlertIsPresent());

        public static bool UntilElementIsAppeared(By pathToElement, int? timeout = null) =>
            WebDriverWait.WithTimeout(timeout).Until(IsElementAppeared(pathToElement));

        public static bool UntilElementIsDisappeared(By pathToElement, int? timeout = null) =>
            WebDriverWait.WithTimeout(timeout).Until(IsElementDisappeared(pathToElement));
    }
}
