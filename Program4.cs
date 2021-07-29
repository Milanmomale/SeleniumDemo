using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
namespace Selenium1
{
    class Program4
    {
        static void RadioButtonTest (string testvalue)
        {
            //Creating a instance 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://demoselsite.azurewebsites.net/Webform4.aspx";

            //Locaitng the radio buttons
            IList<IWebElement> radiobtnlist = driver.FindElements(By.Name("RadioButtonList1"));
            
            foreach (IWebElement rad in radiobtnlist)
            {
                var data = rad.GetAttribute("value");

                if (data.Equals(testvalue))
                {
                    rad.Click();
                    break;
                }  
            }
            var result = driver.FindElement(By.CssSelector("span#lblText")).Text;

            if (result.Contains(testvalue))
            {
               Console.WriteLine("Test Passed"); 
            } 
            else
            {
                Console.WriteLine("Test Failed");
            }

            Thread.Sleep(4000);

            driver.Quit();
        }
        static void Main(string[] args)
        {
            RadioButtonTest("Ruby");
        }
    }
}
