namespace ToolsQA.Tests.Ui.Pages.PageElements
{
    using OpenQA.Selenium;

    public class InputElement : WrapsElement
    {

        public InputElement(IWebElement webElement) : base(webElement)
        {
        }

        public void ClearAndInput(string text, bool moveFocusAway = false)
        {
            if (moveFocusAway)
            {
                text += Keys.Tab;
            }

            WrappedElement.Clear();
            this.InputText(text);
        }

        public void InputText(string inputValue) => WrappedElement.SendKeys(inputValue);
    }
}
