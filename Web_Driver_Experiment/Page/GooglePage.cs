using OpenQA.Selenium;

namespace Web_Driver_Experiment.Page
{
    public sealed class GooglePage
    {
        // Dependency Inversion
        //Encapsulation of fields and share of functionalities.

        private readonly IWebDriver webDriver;
        public GooglePage(IWebDriver webDriver) =>
            this.webDriver = webDriver;

        private IWebElement SearchBar =>
                this.webDriver.FindElement(By.ClassName(classNameToFind: "gLFyf"));

        private IWebElement SearchButton =>
            this.webDriver.FindElement(By.ClassName(classNameToFind: "gNO89b"));

        private IWebElement ForestLink =>
            this.webDriver.FindElement(By.LinkText("Forest - Wikipedia"));
        public void SearchGoogle(string search)
        {
            this.SearchBar.SendKeys(search);
            this.SearchButton.Submit();
        }

        public bool isForestTitleDisplay() =>
            this.ForestLink.Displayed;
    }
}
