using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class NewTab
    {
        static void Main33(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://google.com";
            Actions action = new Actions(driver);
            action.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift).Build().Perform();
            action.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys (Keys.ArrowDown ).SendKeys(Keys.ArrowDown).Perform ();
            for(int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);
                action.SendKeys(Keys.ArrowDown).Build().Perform();
                action.Reset();
            }
            Thread.Sleep(1000);
            action.SendKeys(Keys.Enter).Build().Perform();
            action.Reset();





        }
    }
}
