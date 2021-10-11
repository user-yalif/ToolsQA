namespace ToolsQA.Tests.Ui.Pages
{
    using OpenQA.Selenium;

    public abstract class WrapsElement : BaseElement, IWrapsElement
    {
        public IWebElement WrappedElement { get; }

        protected WrapsElement(IWebElement webElement) : base(webElement)
        {
            WrappedElement = webElement;
        }
    }
}
