namespace ToolsQA.Tests.Ui
{
    using NUnit.Framework;
    using static ToolsQA.Framework.Settings.SettingsConfigurator;

    public class InitialTestClass : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var val = AppSettings;
        }
    }
}
