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
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Amazon",driver.Title);
            IWebElement accounts = driver.FindElement(By.XPath("//span[contains(text(),'Account & Lists')]"));
            var actions = new Actions(driver);
            actions.MoveToElement(accounts).Perform();
            IWebElement signIn = driver.FindElement(By.XPath("(//span[contains(text(),'Sign in')])[1]"));
            signIn.Click();


        }
    }
}
