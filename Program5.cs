using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
namespace Selenium1
{
    class Program5  
    {
        static void RadioButtonTest (string testvalue)
        {
            //Creating a instance 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://demoselsite.azurewebsites.net/Webform4.aspx";

            //Locaitng the radio buttons
            IList<IWebElement> radiobtnlist = driver.FindElements(By.Name("RadioButtonList1"));
            
            //locate using xpath
            //by using chropath extension 
            // IList<IWebElement> radiobtnlist = driver.FindElements(By.XPath("//input[@type='radio']"));


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

        static void CheckBoxTest()
        {
            //Creating a instance 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://demoselsite.azurewebsites.net/Webform4.aspx";

            //Locating the checkbox 
            IWebElement checkbox = driver.FindElement(By.Id("CheckBox1"));

            checkbox.Click();

            var resultElement = driver.FindElement(By.Id("Label1"));

            if (resultElement!=null)
            {
               Console.WriteLine("Test Passed"); 
            }else
            {
                Console.WriteLine("Test Failed");
            }

            Thread.Sleep(4000);
            driver.Quit();

        }


        static void GoogleSearchUsingClass()
        {
             //Creating a instance 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://demoselsite.azurewebsites.net/Webform4.aspx";

            IWebElement searchELement = driver.FindElement(By.ClassName("gLFyf"));
            searchELement.SendKeys("Selenium Nuget");
            searchELement.Submit();

            Thread.Sleep(4000);
            driver.Quit();
        }



        static void Main(string[] args)
        {
            //RadioButtonTest("Ruby");
            //CheckBoxTest();
            GoogleSearchUsingClass();
        }
    }
}