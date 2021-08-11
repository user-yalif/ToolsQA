namespace ToolsQA.Tests.Ui.Pages.PageNavigator.LeftPanel.Elements
{
    using ToolsQA.Tests.Ui.Pages.Pages.Elements;

    public class ElementsSection : BaseSection
    {
        public TestBoxPage TextBox() => Navigate<TestBoxPage>("text-box");

        public CheckBoxPage CheckBox() => Navigate<CheckBoxPage>("checkbox");

        public RadioButtonPage RadioButton() => Navigate<RadioButtonPage>("radio-button");

        public WebTablesPage WebTables() => Navigate<WebTablesPage>("webtables");

        public ButtonsPage Buttons() => Navigate<ButtonsPage>("buttons");

        public LinksPage Links() => Navigate<LinksPage>("links");

        public UploadAndDownloadPage UploadAndDownload() => Navigate<UploadAndDownloadPage>("upload-download");

        public DynamicPropertiesPage DynamicProperties() => Navigate<DynamicPropertiesPage>("dynamic-properties");
    }
}
