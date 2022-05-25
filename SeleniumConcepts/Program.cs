using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("hello");
            IWebDriver driver = new ChromeDriver();
            //driver.Quit();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            //String url = driver.Url;
            //Console.WriteLine(url);
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
        }
    }
}
