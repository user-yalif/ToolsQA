namespace ToolsQA.Framework.Extentions
{
    using OpenQA.Selenium;

    public static class WebDriverExtentions
    {
        public static void GoToUrl(this IWebDriver driver, string url) => driver.Navigate().GoToUrl(url);

        public static void GoBack(this IWebDriver driver) => driver.Navigate().Back();
    }
}
