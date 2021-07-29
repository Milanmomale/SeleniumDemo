using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;

namespace Selenium1
{
    class Program1
    {
        static void Main(string[] args)
        {
            //creating instance of web driver 
            IWebDriver driver  = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //navigating to google.com
            driver.Url = "http://www.google.com";

            //Locate the search bar
            IWebElement SearchTextBox = driver.FindElement(By.Name("q"));
            IWebElement Button = driver.FindElement(By.Name("btnK"));

            //Act
            //Entering the search text
            SearchTextBox.SendKeys("Selenium WebDriver");

            //Perform Search
            //Button.Submit();
            SearchTextBox.Submit();

            //Assert
            IList<IWebElement> links  = driver.FindElements(By.TagName("a"));
            int flag = 0;

            foreach (IWebElement link in links)
            {
                string result = link.GetAttribute("ping");
                if(result.Equals("https://www.selenium.dev/projects/"))
                {
                    flag =1;
                    break;
                }

            }

            if (flag ==1)
                Console.WriteLine("Test Passed");
            else
                Console.WriteLine("Test Failed");

            Thread.Sleep(3000);

            //Close the browser
            driver.Quit();
        }
    }
}
