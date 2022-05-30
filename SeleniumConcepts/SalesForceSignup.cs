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
    internal class SalesForceSignup
    {
        static void Main121(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.FindElement(By.Name("UserFirstName")).SendKeys("Jhon");
            driver.FindElement(By.Name ("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name ("UserEmail")).SendKeys("jhon@gmail.com");
            //driver.FindElement(By.Id("UserTitle-1kc2")).Click();
            SelectElement selectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");

            driver.FindElement(By.Name("CompanyName")).SendKeys("Fujitsu");
            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployees.SelectByText("101 - 500 employees");
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");



            driver.FindElement(By.XPath ("//body/div[@id='main']/div[1]/div[1]/div[6]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[5]/div[1]/div[1]/div[1]")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();

        }
        


    }
}
