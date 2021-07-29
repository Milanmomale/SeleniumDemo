using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instance of web driver 
            IWebDriver driver  = new ChromeDriver(@"D:\Z_SELENIUM\drivers");
            driver.Manage().Window.Maximize();

            //navigating to google.com
            driver.Url = "http://www.google.com";

            //Locate the search bar
            IWebElement SearchTextBox = driver.FindElement(By.Name("q"));

            //Entering the search text
            SearchTextBox.SendKeys("Selenium Nuget");

            //Perform Search
            SearchTextBox.Submit();

            Thread.Sleep(3000);

            //Close the browser
            driver.Quit();
        }
    }
}
