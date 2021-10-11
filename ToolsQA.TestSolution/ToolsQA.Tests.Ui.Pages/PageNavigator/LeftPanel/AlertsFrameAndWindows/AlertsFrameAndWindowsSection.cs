namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.AlertsFrameAndWindows
{
    using ToolsQA.Tests.Ui.Pages.Pages.AlertsFrameAndWindows;

    public class AlertsFrameAndWindowsSection : BaseSection
    {
        public BrowserWindowsPage BrowserWindows()
        {
            return Navigate<BrowserWindowsPage>("browser-windows");
        }

        public AlertsPage Alerts() => Navigate<AlertsPage>("alerts");

        public FramesPage Frames() => Navigate<FramesPage>("frames");

        public NestedFramesPage NestedFrames() => Navigate<NestedFramesPage>("nestedframes");

        public ModalDialogsPage ModalDialogs() => Navigate<ModalDialogsPage>("modal-dialogs");
    }
}
