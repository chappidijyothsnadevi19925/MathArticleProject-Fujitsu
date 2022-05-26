using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class MyAdmin
    {
        static void Main10(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.db4free.net/phpMyAdmin/";
            driver.FindElement(By.Id("input_username")).SendKeys("db123");
            driver.FindElement(By.Id("input_password")).SendKeys("test123");
            driver.FindElement(By.Id("input_go")).Click();
        }
        

    }
}
