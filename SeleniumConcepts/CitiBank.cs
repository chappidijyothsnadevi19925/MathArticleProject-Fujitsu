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
    internal class CitiBank
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IjavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.Url = "https://online.citibank.co.in/";
            //img[@Classname='appClose']
            driver.FindElement(By.ClassName("appClose")).Click();
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.XPath("//div[contains(text(),'Forget User')]")).Click();
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();
            /*  SelectElement selMon = new SelectElement(driver.FindElement(By.CssSelector("")));
              selMon.SelectByText("Mar");*/

            IjavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value='20/08/2000'



        }
    }
}
