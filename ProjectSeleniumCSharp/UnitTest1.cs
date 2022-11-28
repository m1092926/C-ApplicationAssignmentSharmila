using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using System.IO;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace ProjectSeleniumCSharp
{
    public class Tests
    {
        private IWebDriver driver;

        public Tests(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver("C:\\C#assignment\\Chrome\\chromedriver.exe");

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            HomePage homePage = new HomePage(driver);
            homePage.Test1();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Test1();
            SearchPage searchPage = new SearchPage(driver);
            searchPage.Test1();
        }
    }
}