using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Web_Driver_Experiment
{
    public class Tests
    {
        //Hooks in Nunit
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShouldCheckSearchBarWorksWhenClicked()
        {
            //Identify
            var webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.google.com/");

            var searchBar = webDriver.FindElement(By.)
        }
    }
}