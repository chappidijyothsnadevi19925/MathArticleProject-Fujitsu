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
    internal class Flight
    {
        static void Main111(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.net/";
            driver.FindElement(By.CssSelector ("section.hero-wrapper:nth-child(3) div.hero-box.hero-bg.active div.container div.row div.col-lg-12.mx-auto.responsive--column-l div.section-tab.fade-in.glass ul.nav.nav-tabs.listitems li.nav-item:nth-child(2) button.nav-link.waves-effect > span.d-none.d-lg-block.d-xl-block")).Click();
            driver.FindElement(By.Name("from")).Click ();
            Actions action = new Actions(driver);
            action.KeyDown(Keys.Shift).SendKeys("LOS Angeles(LAX)").KeyUp(Keys.Shift).Build ().Perform ();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("to")).Click();
            //action.KeyDown(Keys.Shift).SendKeys("Dallas").KeyUp(Keys.Shift).Build().Perform();
            //Thread.Sleep(2000);
            //  action.SendKeys(Keys.ArrowDown).Build().Perform();
            //driver.FindElement(By.Name("from")).SendKeys("Los angeles(LAX)");


        }
    }
}
