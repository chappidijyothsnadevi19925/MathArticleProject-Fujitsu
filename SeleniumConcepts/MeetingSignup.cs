using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class MeetingSignup
    {
        static void Main44(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting/";
            driver.FindElement(By.Id("truste-consent-button")).Click();
            driver.FindElement(By.PartialLinkText("Try Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("Jhon");
            driver.FindElement(By.Id("last-name")).SendKeys("Wick");
            driver.FindElement(By.Id("login__email")).SendKeys("Jhon@gmail.com");
            driver.FindElement(By.Id("contact-number")).SendKeys("1234567891");
            driver.FindElement(By.Id ("login__password")).SendKeys("welco@145");
            driver.FindElement(By.PartialLinkText("8 - 32 Characters")).Click();
            driver.FindElement(By.PartialLinkText("Contains at least 1 letter")).Click();
            driver.FindElement(By.PartialLinkText("Contains at least 1 number")).Click();
            SelectElement selectSize = new SelectElement(driver.FindElement(By.Name("CompanySize")));
            selectSize.SelectByText("10 - 99");

            driver.FindElement(By.CssSelector("#app > section > div.trial__wrapper > form > section > div > div > div.form-fields__ctaWrapper > button")).Click();


            
        }
    }
}
