using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Web_Driver_Experiment.Page;

namespace Web_Driver_Experiment.Tests
{
    public class GoogleTests
    {
        IWebDriver webDriver = new ChromeDriver();

        //Hooks in Nunit
        //The Setup is that before running any operation run the setup first
        [SetUp]
        public void Setup() =>
            webDriver.Navigate().GoToUrl("https://www.google.com/");

        [Test]
        public void ShouldCheckIfSearchBarWorksWhenClicked()
        {
            // Arrange
            var googlePage = new GooglePage(this.webDriver);
            
            // Act
            googlePage.SearchGoogle("forest");

            // Assert
            Assert.That(googlePage.isForestTitleDisplay, Is.True);

            webDriver.Close();
        }
    }
}