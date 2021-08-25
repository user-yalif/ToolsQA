namespace ToolsQA.Tests.Ui
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using ToolsQA.Framework.Drivers;
    using ToolsQA.Framework.Extentions;
    using ToolsQA.Framework.Helpers;
    using ToolsQA.Framework.Utils;
    using static ToolsQA.Framework.SetUp.SettingsConfigurator;

    public class BaseTest
    {
        private static string ScreenshotsDirectory => PathUtils.CreatePathFromAppBaseDirectory(AppSettings.Paths.ScreenshotsOutput);
        private static string DownloadDirectory => PathUtils.CreatePathFromAppBaseDirectory(AppSettings.Paths.DownloadsDirectory);

        protected static string TestName => TestContext.CurrentContext.Test.MethodName;
        private static TestStatus TestStatus => TestContext.CurrentContext.Result.Outcome.Status;

        [SetUp]
        public virtual void SetUp()
        {
            Logger.Log.Info("{0} test is started", TestName);
            Logger.Log.Info("Go to {0}", AppSettings.BaseUri);

            WebDriverManager.Driver.GoToUrl(AppSettings.BaseUri);
        }

        [TearDown]
        public virtual void DisposeTest()
        {
            Logger.Log.Info("{0} test is finished with status: {1}", TestName, TestStatus.ToString().ToUpper());

            if (TestStatus == TestStatus.Failed)
            {
                DirectoryUtils.CreateDirectoryIfDoesNotExist(ScreenshotsDirectory);
                var screenshotName = Screenshoter.TakeScreenshot(WebDriverManager.Driver, ScreenshotsDirectory, TestName);

                Logger.Log.Info("Screenshot {0} was taken and put to {1}", screenshotName, ScreenshotsDirectory);
            }

            WebDriverManager.ReleaseDriver();
            Logger.Log.Dispose();
        }
    }
}
