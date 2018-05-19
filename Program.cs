using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FinanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
             IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio Projects/FinanceScraper/bin/Debug/netcoreapp2.0/");

            driver.Navigate().GoToUrl("https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Ffinance.yahoo.com%2F");

            var userNameField = driver.FindElement(By.Id("login-username"));
            var loginUserButton = driver.FindElement(By.Id("login-signin"));            
            userNameField.SendKeys("testscraper");

            loginUserButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 

            var userPasswordField = driver.FindElement(By.Id("login-passwd"));
            var loginPasswordButton = driver.FindElement(By.Id("login-signin")); 
            userPasswordField.SendKeys("scrapePass");
            loginPasswordButton.Click();

        }
    }
}


