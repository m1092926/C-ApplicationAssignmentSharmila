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
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
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
            IWebElement moblieNumber = driver.FindElement(By.Id("ap_email"));
            
            moblieNumber.SendKeys("9163730577");
            IWebElement moblieNumberContinue = driver.FindElement(By.Id("continue"));
            moblieNumberContinue.Click();
            IWebElement password = driver.FindElement(By.Id("ap_password"));
            password.SendKeys("Good@762");

            IWebElement signInSubmit = driver.FindElement(By.Id("signInSubmit"));
            signInSubmit.Click();
            IWebElement loginSuccessfully = driver.FindElement(By.Id("nav - link - accountList - nav - line - 1"));
            if ((loginSuccessfully.Text).Contains("Hello"))
            {
                Console.WriteLine("Login Successfully");
            }
            else {
                Console.WriteLine("Login UnSuccessfully");
            }

        }
    }
}
