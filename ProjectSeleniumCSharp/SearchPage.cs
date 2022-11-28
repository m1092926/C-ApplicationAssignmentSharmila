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
    class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
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
            IWebElement Search = driver.FindElement(By.Id("twotabsearchtextbox"));

            Search.SendKeys("Biodis Kraft Paper Cup 250 ML with Black LID (Pack of 50)");

            Search.SendKeys(Keys.Enter);
            IWebElement ItemFound = driver.FindElement(By.Id("a-autoid-1-announce"));
            ItemFound.Click();
            IWebElement addToCart = driver.FindElement(By.Id("nav-cart-count"));
            addToCart.Click();

            IWebElement proccedToBuy = driver.FindElement(By.Id("sc-buy-box-ptc-button"));
            proccedToBuy.Click();
            
        }
    }
}
