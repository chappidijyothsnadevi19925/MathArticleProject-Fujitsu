using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Demo4
    {
        static void Main0(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            // driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame("login_page");
            //  driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            driver.FindElement(By.Id ("email")).SendKeys("welcome@gmail.com");
            driver.FindElement(By.LinkText("CONTINUE")).Click();
            driver.SwitchTo().DefaultContent();

        }
    }
}
