using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Selenium1
{
    class RmmLogin
    {
        static void Main(string[] args)
        {
            //creating instance of web driver 
            IWebDriver driver  = new ChromeDriver(@"D:\Z_SELENIUM\drivers");
            driver.Manage().Window.Maximize();

            //navigating to google.com
            driver.Url = "http://www.google.com";

            //Locate the search bar
            IWebElement usernameTextBox = driver.FindElement(By.Name("q"));
            IWebElement passwordTextBox = driver.FindElement(By.Name("q"));
            
            //Entering the search text
            usernameTextBox.SendKeys("Selenium Nuget");
            passwordTextBox.SendKeys("Selenium Nuget");

            //Perform Search
            passwordTextBox.Submit();

            Thread.Sleep(3000);

            //Close the browser
            driver.Quit();
        }
    }
}
