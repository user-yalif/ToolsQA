namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Forms
{
    using ToolsQA.Tests.Ui.Pages.Pages.Forms;

    public class FormsSection : BaseSection
    {
        public PracticeFormPage PracticeForm() => Navigate<PracticeFormPage>("automation-practice-form");
    }
}
