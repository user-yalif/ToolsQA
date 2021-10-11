namespace ToolsQA.Tests.Ui.Pages.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class Header : BasePage
    {
        [FindsBy(How.ClassName, "main-header")]
        IWebElement HeaderRibbon { get; set; }

        public string GetText() => HeaderRibbon.Text;
    }
}
