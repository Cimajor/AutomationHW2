using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1 
{
     class GoogleHomePageMethods : Google
    {
        ChromeDriver chrome;
        GoogleHomePageSelectors GoogleHomePageSelectors = new GoogleHomePageSelectors();

        public void OpenHomePage()    //Open Google home page
        {
            chrome = new ChromeDriver("C:\\");
            chrome.Navigate().GoToUrl(GoogleHomePageSelectors.homePageUrl());
        }

        public void InputInSearchField(String searchInput) // Input something in search fied and press search button
        {
            chrome.FindElementById(GoogleHomePageSelectors.SearchFieldID).SendKeys(searchInput);
            chrome.FindElementById(GoogleHomePageSelectors.ConfirmSearchButtonId).Click();
        }

        public void CloseBrowser()
        {
            chrome.Quit();
        }


    }
}
