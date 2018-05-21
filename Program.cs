using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace FinanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new driver class
             IWebDriver driver = new ChromeDriver("/Users/matthewrizzini/Desktop/Visual Studio Projects/FinanceScraper/bin/Debug/netcoreapp2.0/");

            driver.Navigate().GoToUrl("https://login.yahoo.com/config/login?.intl=us&.lang=en-US&.src=finance&.done=https%3A%2F%2Ffinance.yahoo.com%2F");


            // navigating to username input box and clicking to sign in
            var userNameField = driver.FindElement(By.XPath("//*[@id='login-username']"));
            var loginUserButton = driver.FindElement(By.XPath("//*[@id='login-signin']"));            
            userNameField.SendKeys("testscraper");
            loginUserButton.Click();

            // waiting 5 seconds for page to load then to go onto enter password. need to throw an exception here
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); 

            // sending password to input box and signing in 
            var userPasswordField = driver.FindElement(By.XPath("//*[@id='login-passwd']"));
            var loginPasswordButton = driver.FindElement(By.XPath("//*[@id='login-signin']")); 
            userPasswordField.SendKeys("scrapePass");
            loginPasswordButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); 


            var portfolioButton = driver.FindElement(By.XPath("//*[@id='Nav-0-DesktopNav']/div/div[3]/div/div[1]/ul/li[2]/a"));

            portfolioButton.Click();

            // Actions action = new Actions(driver);
            // IWebElement portfolioButton = driver.FindElement(By.XPath("//*[@id='Nav-0-DesktopNav']/div/div[3]/div/div[1]/ul/li[2]/a"));
            // action.moveToElement(DropDown tab element).click().moveToElement(Tab you want to click element).click().build().perform();

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 

            // var element = driver.FindElement(By.LinkText("My Portfolio"));
 
            // var action = new Actions(driver);
 
            // action.MoveToElement(element).Perform();

            
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
 
            // var subElement = driver.FindElement(By.LinkText("Scraper"));
 
            // action.MoveToElement(subElement);
 
            // action.Click();
 
            // action.Perform();


            // Actions action = new Actions(driver);
            // wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='img-defer-id-1-6775']")));
            // action.MoveToElement(driver.FindElement(By.XPath("//*[@id='img-defer-id-1-6775']"))).Build().Perform(); 
            // wait.Until(ExpectedConditions.ElementIsClickable(By.XPath("//*[@id='account-sub-nav']/div/div[2]/ul/li[1]/div/span/span[3]/a"))).Click();

            // var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            // var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='Nav-0-DesktopNav']/div/div[3]/div/div[1]/ul/li[2]/a")));

            // action.MoveToElement(element).Perform();

            // var subElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("Scraper")));
            
            // action.MoveToElement(subElement);
 
            // action.Click();
 
            // action.Perform();


            


        }
    }
}


