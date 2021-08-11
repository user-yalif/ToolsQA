namespace ToolsQA.Tests.Ui
{
    using NUnit.Framework;
    using static ToolsQA.Framework.Settings.SettingsConfigurator;

    public class InitialTestClass : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            Log.Info("Debbug mode info");
            Log.Error("ERROR!");
        }
    }
}
