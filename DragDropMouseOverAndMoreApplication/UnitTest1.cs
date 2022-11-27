using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;

namespace DragDropMouseOverAndMoreApplication
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            IWebDriver driver = new ChromeDriver("C:\\C#assignment\\Chrome\\chromedriver.exe");
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            options.AddArguments("enable-strict-powerful-feature-restrictions");
            options.AddArguments("disable-geolocation");
            ChromeDriver driver1 = new ChromeDriver(options);
            var actions = new Actions(driver1);
            var wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(6));

            driver1.Navigate().GoToUrl("https://www.spicejet.com/");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(text(),'Add-ons')]")));
            IWebElement element = driver1.FindElement(By.XPath("//div[contains(text(),'Add-ons')]"));
            actions.MoveToElement(element).Perform();
            IWebElement element2 = driver1.FindElement(By.Id("(//div[contains(text(),'Visa Services')])[1]"));
            element2.Click();
        }
        [Test]
        public void Test2()
        {


            IWebDriver driver = new ChromeDriver("C:\\C#assignment\\Chrome\\chromedriver.exe");
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            ChromeDriver driver1 = new ChromeDriver(options);
            var actions = new Actions(driver1);
            var wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(6));

            driver1.Navigate().GoToUrl("https://jqueryui.com/droppable/");

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement targetElement = driver1.FindElement(By.Id("draggable"));
            IWebElement sourceElement = driver1.FindElement(By.Id("droppable"));
            actions.DragAndDrop(sourceElement, targetElement).Perform();

            Assert.AreEqual("Dropped!", targetElement.Text);

        }
    }
    }
