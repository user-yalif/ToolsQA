namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel
{
    using System;
    using ToolsQA.Framework.Drivers;
    using ToolsQA.Framework.Extentions;
    using ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Interfaces;
    using static ToolsQA.Framework.Settings.SettingsConfigurator;

    public class BaseSection : ILeftPanelSection
    {
        protected string BaseUri => AppSettings.BaseUri;

        public T Navigate<T>(string path) where T : BasePage, new()
        {
            WebDriverManager.Driver.GoToUrl(new UriBuilder(BaseUri)
            {
                Path = path
            }.Uri.AbsoluteUri);

            return new T();
        }
    }
}
