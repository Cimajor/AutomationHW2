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
        ChromeDriver chrome;


        public void OpenHomePage()    //Open Google home page
        {
            GoogleHomePageSelectors GoogleHomePageSelectors = new GoogleHomePageSelectors();
            chrome = new ChromeDriver("C:\\");
            chrome.Navigate().GoToUrl(GoogleHomePageSelectors.homePageUrl);
        }

        public void LoginToGmail(string loginName, string loginPassword)
        {
            chrome.FindElementById(GoogleHomePageSelectors.loginButtonId).Click();
            chrome.FindElementById(LoginPageSelectors.userMailLoginId).SendKeys(loginName);
            chrome.FindElementById(LoginPageSelectors.confirmLoginId).Click();
            Thread.Sleep(1500); //Problems with wait.Until
            //var wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10)); //waiter for password field
            //wait.Until(chrome => !chrome.FindElement(By.Id(LoginPageSelectors.passwordFieldId)).Displayed);
            chrome.FindElementById(LoginPageSelectors.passwordFieldId).SendKeys(loginPassword);
            chrome.FindElementById(LoginPageSelectors.passwordConfirmationButtonId).Click();
            chrome.Navigate().GoToUrl(MailVariable.gmailMailUrl);
        }
    }
}
