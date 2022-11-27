using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\C#assignment\\Chrome\\chromedriver.exe");

            driver.Url = "https://demo.automationtesting.in/Register.html/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@ng-model='FirstName']")).SendKeys("Sharmila");
            driver.FindElement(By.XPath("//input[@ng-model='LastName']")).SendKeys("Paul");
            driver.FindElement(By.XPath("//textarea[@ng-model='Adress']")).SendKeys("Click Nicon studio");
            WebElement upload_file = (WebElement)driver.FindElement(By.XPath("//input[@type='file']"));
            upload_file.SendKeys("C:\\C#assignment\\Chrome\\download.jfif");

        }
    }
}
