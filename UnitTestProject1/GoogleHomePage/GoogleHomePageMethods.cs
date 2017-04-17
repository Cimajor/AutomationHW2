using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1 
{
     class GoogleHomePageMethods
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
            chrome.FindElementById(GoogleHomePageSelectors.confirmSearchButtonId).Click();
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
