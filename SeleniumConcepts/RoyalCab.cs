using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class RoyalCab
    {
        static void Main111(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.royalcaribbean.com/";
            //driver.SwitchTo().IFrame(driver.FindElement(By.XPath("//body/div[10]/div[2]/div[1]/*[1]")));
            //driver.SwitchTo ().Frame(driver.FindElement(By.XPath("//body/div[10]/div[2]/div[1]/iframe[1]")));
            // driver.FindElement(By.CssSelector ("div.app div.app__view form.form-page div.form-page__email div.email.email--invalid > input.email__input")).SendKeys ("lavanyajyothsna410@gmail.com");
            driver.FindElement(By.XPath("//body/div[7]/div[2]/div[1]")).Click();
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[5]/div[1]/div[1]/div[1]/div[3]/div[1]/nav[1]/div[6]/a[1]/span[1]")).Click();

        }
    }
}
