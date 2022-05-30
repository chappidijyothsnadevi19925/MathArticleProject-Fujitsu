using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Rightclicknotworking
    {
        static void Main70(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            
            string alertText=  driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);
            //driver.SwitchTo().Alert().sendkeys("");  It is for if we want to add any info after click on alert then we can use
            driver.SwitchTo().Alert().Accept();

        }
    }
}
