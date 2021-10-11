namespace ToolsQA.Framework.Settings.Models
{
    using ToolsQA.Framework.Settings.Enums;

    public class AppSettingsModel
    {
        public Environments Environmnet { get; set; }

        public BrowserType Browser { get; set; }

        public string BaseUri { get; set; }

        public LoggerType Logger { get; set; }

        public PathsModel Paths { get; set; }

        public class PathsModel
        {
            public string ScreenshotsOutput { get; set; }

            public string DownloadsDirectory { get; set; }
        }
    }
}
