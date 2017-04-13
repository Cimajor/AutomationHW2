using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver chrome;
        [TestMethod]
        public void TestMethod1()
        {
            int counter = 1;

            chrome = new ChromeDriver("C:\\");
            String baseUrl = "http://www.google.com.ua/";
            chrome.Navigate().GoToUrl(baseUrl);
            
            chrome.FindElementById("lst-ib").SendKeys("Automation Testing");
            chrome.FindElementById("_fZl").Click();
            
#pragma warning disable CS0618 // Тип или член устарел
            chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Actions action = new Actions(chrome);

            for (; counter <= 5; counter++)
            {
                IWebElement body = chrome.FindElement(By.XPath(".//*[@id='rso']/div/div/div["+counter+"]/div/h3/a"));
                action.KeyDown(Keys.Control).MoveToElement(body).Click().Perform();

            }
            chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

#pragma warning restore CS0618 // Тип или член устаре

        }
        [TestCleanup]
        public void TearDown()
        {
            chrome.Quit();
        }
    }
}
