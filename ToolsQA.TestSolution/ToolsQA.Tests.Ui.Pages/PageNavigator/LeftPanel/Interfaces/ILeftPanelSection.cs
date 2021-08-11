namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Interfaces
{
    public interface ILeftPanelSection
    {
        T Navigate<T>(string path) where T : BasePage, new();
    }
}
