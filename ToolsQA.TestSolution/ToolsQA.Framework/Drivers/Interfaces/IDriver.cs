namespace ToolsQA.Framework.Drivers.Interfaces
{
    using OpenQA.Selenium;

    public interface IDriver
    {
        IWebDriver SetUp(string pathToDriver, string downloadPath = null);
    }
}
