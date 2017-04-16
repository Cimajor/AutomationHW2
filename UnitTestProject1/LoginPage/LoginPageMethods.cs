using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    class LoginPageMethods
    {
        
        public static void LoginToGmail(string loginName, string loginPassword)
        {
            ChromeDriver chrome;
            chrome = new ChromeDriver("C:\\");
            chrome.Navigate().GoToUrl(GoogleHomePageSelectors.homePageUrl);
            chrome.FindElementById(GoogleHomePageSelectors.loginButtonId).Click();
            chrome.FindElementById(LoginPageSelectors.userMailLoginId).SendKeys(loginName);
            chrome.FindElementById(LoginPageSelectors.confirmLoginId).Click();
            chrome.FindElementById(LoginPageSelectors.userMailPasswordId).SendKeys(loginPassword);
            chrome.FindElementById(LoginPageSelectors.passwordConfirmationButtonId).Click();
            chrome.Navigate().GoToUrl(MailVariable.gmailMailUrl);
        }
    }
}
