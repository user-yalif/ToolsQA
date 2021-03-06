namespace ToolsQA.Tests.Ui
{
    using NUnit.Framework;
    using ToolsQA.Framework.Helpers;
    using ToolsQA.Tests.Ui.Pages.PageNavigator;
    using static ToolsQA.Framework.SetUp.SettingsConfigurator;

    public class InitialTestClass : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var textBoxPage = PageNavigator.Elements.TextBox();

            var headerText = textBoxPage.OnHeader().GetText();

            Assert.That(headerText, Is.EqualTo("Text Box"), "Incorrect header text.");

            textBoxPage.FillOutTextFieldsAndSubmit("John Smith", "jsmith@qa.qa", "118 St., Epsom, UK", "126 Arctic st., Dnipro");

            Logger.Log.Error("This is the error {0}", "End of TestMethod");
        }
    }
}
