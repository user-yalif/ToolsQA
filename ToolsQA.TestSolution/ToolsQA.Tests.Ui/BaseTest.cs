namespace ToolsQA.Tests.Ui
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using ToolsQA.Framework.Drivers;
    using ToolsQA.Framework.Extentions;
    using ToolsQA.Framework.Helpers;
    using ToolsQA.Framework.Utils;
    using static ToolsQA.Framework.Settings.SettingsConfigurator;

    public class BaseTest
    {
        private static string ScreenshotsDirectory => PathUtils.CreatePathFromAppBaseDirectory(AppSettings.Paths.ScreenshotsOutput);
        private static string DownloadDirectory => PathUtils.CreatePathFromAppBaseDirectory(AppSettings.Paths.DownloadsDirectory);

        protected static string TestName => TestContext.CurrentContext.Test.MethodName;
        private static TestStatus TestStatus => TestContext.CurrentContext.Result.Outcome.Status;

        [SetUp]
        public virtual void SetUp()
        {
            WebDriverManager.Driver.GoToUrl(AppSettings.BaseUri);
        }

        [TearDown]
        public virtual void DisposeTest()
        {
            if (TestStatus == TestStatus.Failed)
            {
                DirectoryUtils.CreateDirectoryIfDoNotExist(ScreenshotsDirectory);
                var screenshotName = Screenshoter.TakeScreenshot(WebDriverManager.Driver, ScreenshotsDirectory, TestName);
            }

            WebDriverManager.ReleaseDriver();
        }
    }
}
