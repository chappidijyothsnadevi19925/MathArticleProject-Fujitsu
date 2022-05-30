using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class b4free
    {
        static void Main00(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin ")).Click();
            ReadOnlyCollection<string> windows=driver.WindowHandles;
            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);
            Console.WriteLine(driver.Title);
            driver.SwitchTo().Window(windows[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            driver.FindElement(By.Id("input_password")).SendKeys("Admin@123");
            driver.FindElement(By.Id("input_go")).Click();



        }
    }
}
