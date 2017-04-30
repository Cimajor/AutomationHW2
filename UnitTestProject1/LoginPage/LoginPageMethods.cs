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
    class LoginPageMethods
    {
        private Base baseIns;
        ChromeDriver chrome;

        public LoginPageMethods(Base baseIns)
        {
            this.baseIns = baseIns;
            chrome = baseIns.getChromeDriver();
        }

        public void LoginToGmail(string loginName, string loginPassword)
        {
            
            chrome.FindElementById(GoogleHomePageSelectors.loginButtonId).Click();
            chrome.FindElementById(LoginPageSelectors.userMailLoginId).SendKeys(loginName);
            chrome.FindElementById(LoginPageSelectors.confirmLoginId).Click();
            chrome.FindElementById(LoginPageSelectors.passwordFieldId).SendKeys(loginPassword);
            chrome.FindElementById(LoginPageSelectors.passwordConfirmationButtonId).Click();
            chrome.Navigate().GoToUrl(MailVariable.gmailMailUrl);
        }
    }
}
