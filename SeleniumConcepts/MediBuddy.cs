using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class MediBuddy
    {
        static void Main22(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://medibuddy.co.uk/sign-up/";
            driver.FindElement(By.Id("name")).SendKeys("Jhon");
            driver.FindElement(By.Id("email")).SendKeys("Jhon@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("12345");
            driver.FindElement(By.Id("password_confirm")).SendKeys("12345");
            driver.FindElement(By.Id("accept")).Click();
            driver.FindElement(By.Id("marketing")).Click();
            driver.FindElement(By.CssSelector ("#container > section > div > div > div > div.register-panel > form > button")).Click();
        }
    }
}
