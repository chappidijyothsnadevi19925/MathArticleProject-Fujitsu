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
    internal class Facebook
    {
       static void Main88(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            // driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/r.php";
            driver.FindElement(By.Name("firstname")).SendKeys("Jhon");
            driver.FindElement(By.Name("lastname")).SendKeys("basel");
            driver.FindElement(By.Name("reg_passwd__")).Click();
            driver.FindElement(By.Name("reg_email__")).SendKeys("devi@gmail.com");

            SelectElement selectDay = new SelectElement(driver.FindElement (By.Id("day")));
            selectDay.SelectByText("26");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Name("birthday_month")));
            selectMonth.SelectByText("May");

            SelectElement selectYear = new SelectElement(driver.FindElement(By.Name("birthday_year")));
            selectYear.SelectByText("2011");

            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

           // driver.FindElement(By.XPath("//*[@id="u_2_o_Su"]/span[1]/label")).Click();
           // driver.FindElement(By.XPath("//*[@id="day"]")).Click();
        }

    }
}
