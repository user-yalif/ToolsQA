namespace ToolsQA.Tests.Ui.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using ToolsQA.Framework.Drivers;

    public abstract class BaseElement
    {
        protected IWebDriver Driver { get; set; }

        protected BaseElement() : this(WebDriverManager.Driver)
        {
        }

        protected BaseElement(ISearchContext searchContext)
        {
            Driver = WebDriverManager.Driver;
            PageFactory.InitElements(searchContext, this);
        }
    }
}
