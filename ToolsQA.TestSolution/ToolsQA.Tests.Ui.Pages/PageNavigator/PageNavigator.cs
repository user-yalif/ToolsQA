namespace ToolsQA.Tests.Ui.Pages.PageNavigator
{
    using ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.AlertsFrameAndWindows;
    using ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Elements;
    using ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Forms;
    using ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Interactions;
    using ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Widgets;

    public static class PageNavigator
    {
        public static ElementsSection Elements => new();

        public static FormsSection Forms => new();

        public static AlertsFrameAndWindowsSection AlertsFrameAndWindows => new();

        public static WidgetsSection Widgets => new();

        public static InteractionsSection Interactions => new();
    }
}
