namespace ToolsQA.Tests.Ui.Pages.PageElements
{
    using OpenQA.Selenium;

    public class ButtonElement : WrapsElement
    {
        public ButtonElement(IWebElement webElement) : base(webElement)
        {
        }

        public void Click() => WrappedElement.Click();
    }
}
