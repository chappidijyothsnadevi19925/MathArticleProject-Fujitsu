using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class OpenEMR
    {
        static void Main121(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.openemr.io/b/openemr/interface/login/login.php?site=default";
            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");
            SelectElement selectLanguage=new SelectElement(driver.FindElement(By.XPath ("//body/form[@id='login_form']/div[1]/div[1]/div[3]/div[1]/select[1]")));

            selectLanguage.SelectByValue("18");
            
            driver.FindElement(By.Id("login-button")).Click();

            //Actions action = new Actions(driver);
            //action.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift).Build().Perform();
            //driver.SwitchTo().Frame("logoutinnerframe");
            driver.FindElement(By.CssSelector("body.min-vw-100:nth-child(2) nav.navbar.navbar-expand-xl.navbar-light.bg-light.py-0:nth-child(1) div.collapse.navbar-collapse:nth-child(3) div.appMenu.navbar-nav.mr-auto div:nth-child(6) div.menuSection.dropdown > div.menuLabel.px-1.dropdown-toggle.oe-dropdown-toggle")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'New/Search')]")).Click();

        }
    }
}
