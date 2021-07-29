using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace Selenium1
{
    class Program3
    {

        static void AddTest()
        {
            //download the browser binry at runtime
            new DriverManager().SetUpDriver(new ChromeConfig());

            //Initializing the drivers 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://demoselsite.azurewebsites.net/Webform1.aspx";

            //Locate the element
           /* IWebElement Num1  = driver.FindElement(By.Id("txtno1"));
            IWebElement Num2  = driver.FindElement(By.Id("txtno2"));
            IWebElement Select  = driver.FindElement(By.Id("cmbop"));
            IWebElement Button  = driver.FindElement(By.Id("btnsrcvcalc"));  */

            //locate by another way
            IWebElement Num1  = driver.FindElement(By.CssSelector("input#txtno1"));
            IWebElement Num2  = driver.FindElement(By.CssSelector("input#txtno2"));
            IWebElement Select  = driver.FindElement(By.CssSelector("select#cmbop"));
            IWebElement Button  = driver.FindElement(By.CssSelector("input[type='button']"));

            //Performing the action
            Num1.SendKeys("10");
            Num2.SendKeys("20");
            new SelectElement(Select).SelectByValue("Divide");
            Button.Click();

           /* driver.SwitchTo().Alert().Dismiss();
            Console.WriteLine("Test Passed");*/

            IAlert alert = driver.SwitchTo().Alert();

            if (alert.Text.Contains("zero"))
                Console.WriteLine("Test Passed");
            else
                Console.WriteLine("Test Failed");

            alert.Dismiss();    
            
            Thread.Sleep(3000);

            driver.Quit();        
        }


        static void Main(string[] args)
        {
                AddTest();
        }
    }
}
