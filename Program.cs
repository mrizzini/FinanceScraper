using System;
using System.Collections.Generic;
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

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15); 


            var portfolioButton = driver.FindElement(By.XPath("//*[@id='Nav-0-DesktopNav']/div/div[3]/div/div[1]/ul/li[2]"));

            portfolioButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);  

            var popups = driver.FindElements(By.XPath("//*[@id='fin-tradeit']/div[2]/div/div/div[2]/button[2]"));

            // var popupButton = driver.FindElement(By.XPath("//*[@id='fin-tradeit']/div[2]/div/div/div[2]/button[2]"));

            if (popups.Count > 0)
            {
                System.Console.WriteLine("popup is {0}", popups[0]);
                popups[0].Click();
            }
            else
            {
                System.Console.WriteLine("Popup not found");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);  
            
            var myScraperButton = driver.FindElement(By.XPath("//*[@id='main']/section/section/div[2]/table/tbody/tr[2]/td[1]/a"));

            myScraperButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);  
            
            var stockList = driver.FindElements(By.XPath("//*[@id='main']/section/section[2]/div[2]/table/tbody/tr"));

            System.Console.WriteLine("stocklist count is {0}", stockList.Count);

            foreach (var stock in stockList)
            {
                System.Console.WriteLine("Stock is " + stock.FindElement(By.ClassName("_1_2Qy")).Text);
            }



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




            // var elemTable = driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));

            // var lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
            // if (lstTdElem.Count > 0)
            // {
            //     foreach (var elemTd in lstTdElem)
            //     {
            //         // "\t\t" for Tab Space
            //         strRowData = strRowData + elemTd.Text + "\t\t";
            //     }
            // }
            // Console.WriteLine(strRowData);
            // strRowData="";

            


        }
    }
}


