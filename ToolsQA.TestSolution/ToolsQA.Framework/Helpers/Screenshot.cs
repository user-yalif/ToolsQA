namespace ToolsQA.Framework.Helpers
{
    using OpenQA.Selenium;
    using System;

    public static class Screenshot
    {
        private static string ConfigureScreenshotName(string outputPath, string screenshotName) =>
            string.Concat(outputPath, @$"\{DateTime.Now:yyyy-MM-dd-HH-mm-ss}{"_" + screenshotName}.png");

        public static string TakeScreenshot(IWebDriver driver, string outputPath, string testName)
        {
            var screenshotName = ConfigureScreenshotName(outputPath, testName);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(screenshotName, ScreenshotImageFormat.Png);

            return screenshotName;
        }
    }
}
