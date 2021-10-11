namespace ToolsQA.Tests.Ui.Pages
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using ToolsQA.Tests.Ui.Pages.Pages;

    public class BasePage : BaseElement
    {
        protected IWebElement FindElement(By by) => Driver.FindElement(by);
        protected IList<IWebElement> FindElements(By by) => Driver.FindElements(by);

        public BasePage() : base()
        {
        }

        public Header OnHeader() => new();
    }
}
