
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;
using SeleniumExtras.WaitHelpers;
namespace KeyBoardAndMouseEvents
{
    [TestFixture]
  public   class Program
    {
       [Test]
        public void example1() {
            var driver = new FirefoxDriver();
            var actions = new Actions(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));

            driver.Navigate().GoToUrl("https://jqueryui.com/droppable");
          
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement targetElement = driver.FindElement(By.Id("draggable"));
            IWebElement sourceElement = driver.FindElement(By.Id("droppable"));
            actions.DragAndDrop(sourceElement,targetElement).Perform();

            Assert.AreEqual("Dropped!",targetElement.Text);

        }



    }

}


    
