namespace ToolsQA.Framework.Settings.Models
{
    using ToolsQA.Framework.Settings.Enums;

    public class AppSettingsModel
    {
        public Environments Environmnet { get; set; }
        public string Browser { get; set; }
        public string BaseUri { get; set; }
        public PathsModel Paths { get; set; }

        public class PathsModel
        {
            public string ScreenshotsOutput { get; set; }
            public string DownloadsDirectory { get; set; }
        }
    }
}
