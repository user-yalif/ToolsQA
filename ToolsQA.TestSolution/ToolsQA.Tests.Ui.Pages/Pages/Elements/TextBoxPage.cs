namespace ToolsQA.Tests.Ui.Pages.Pages.Elements
{
    using SeleniumExtras.PageObjects;
    using ToolsQA.Tests.Ui.Pages.PageElements;

    public class TextBoxPage : BasePage
    {
        [FindsBy(How.Id, "userName")]
        private InputElement FullNameInput { get; set; }

        [FindsBy(How.Id, "userEmail")]
        private InputElement EmailInput { get; set; }

        [FindsBy(How.Id, "currentAddress")]
        private InputElement CurrentAddressInput { get; set; }

        [FindsBy(How.Id, "permanentAddress")]
        private InputElement PermanentAddressInput { get; set; }

        [FindsBy(How.Id, "submit")]
        private ButtonElement SubmitButton { get; set; }

        public void FillOutTextFieldsAndSubmit(string fullName, string email, string currentAddress, string permanentAddres)
        {
            FullNameInput.ClearAndInput(fullName, true);
            EmailInput.ClearAndInput(email, true);
            CurrentAddressInput.ClearAndInput(currentAddress, true);
            PermanentAddressInput.ClearAndInput(permanentAddres, true);
            SubmitButton.Click(); 
        }
    }
}
