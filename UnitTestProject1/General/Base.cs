using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    class Base
    {
        protected static ChromeDriver chrome;

        public static ChromeDriver createChrome()
        {
            if(chrome == null)
            {
                chrome = new ChromeDriver("C:\\");
            }
            return chrome;
        }

        public Base()
        {
            chrome = new ChromeDriver("C:\\");
        }

        public void OpenHomePage()    //Open Google home page
        {
            String baseUrl = "http://www.google.com.ua/";
            chrome.Navigate().GoToUrl(baseUrl);
            chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

        }

        public ChromeDriver getChromeDriver()
        {
            return chrome;
        }

        public void CloseBrowser()
        {
            chrome.Quit();
        }

        public void waiter()
        {
            const int defaultWait = 4;
            WebDriverWait Wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(defaultWait));
        }
    }
}
