using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace UnitTestProject1 
{
     class GoogleHomePageMethods : Google
    {
        ChromeDriver chrome;
        

        public void OpenHomePage()    //Open Google home page
        {
            GoogleHomePageSelectors GoogleHomePageSelectors = new GoogleHomePageSelectors();
            chrome = new ChromeDriver("C:\\");
            chrome.Navigate().GoToUrl(GoogleHomePageSelectors.homePageUrl);
        }

        public void InputInSearchField(String searchInput) // Input something in search fied and press search button
        {

            chrome.FindElementById(GoogleHomePageSelectors.searchFieldID).SendKeys(searchInput);
            Thread.Sleep(1500);
            chrome.FindElementById(GoogleHomePageSelectors.confirmSearchButtonId).Click();
            Thread.Sleep(1500);
        }

        public void ClickOnLoginButton()
        {
            chrome.FindElementById(GoogleHomePageSelectors.loginButtonId).Click();
        }

        public void CloseBrowser()
        {
            chrome.Quit();
        }


    }
}
