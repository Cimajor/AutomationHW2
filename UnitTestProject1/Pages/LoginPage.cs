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
    class LoginPage : Driver
    {
        //old google login UI
        public static string testUserName = "illia.test.milevskiy@gmail.com";
        public static string loginGoogleButton = "gb_70";
        public static string userLoginMailFieldId = "Email";
        public static string confirmLoginId = "next";
        public static string testUserPassword = "123asdQWE";
        public static string passwordFieldId = "Passwd";
        public static string passwordConfirmationButtonId = "signIn";
        public static string denialPhoneConfirmation = ".//*[@id='view_container']/div/div/div/div/div[1]/div[3]/div[1]";

        //new google login UI
        public static string userLoginMailFieldIdNew = "identifierId";
        public static string xPathconfirmLoginIdNew = ".//*[@id='identifierNext']/content/span";
        public static string xPathpasswordFieldIdNew = ".//*[@id='password']/div[1]/div/div[1]/input";
        public static string xPathpasswordConfirmationButtonIdNew = ".//*[@id='passwordNext']/content/span";

        WebDriverWait Wait;

        public void LoginToGmailOld(string loginName, string loginPassword, string mailAddress)
        {

            DriverInstance().FindElementById(loginGoogleButton).Click();
            DriverInstance().FindElementById(userLoginMailFieldId).SendKeys(testUserName);
            DriverInstance().FindElementById(confirmLoginId).Click();
            DriverInstance().FindElementById(passwordFieldId).SendKeys(loginPassword);
            DriverInstance().FindElementById(passwordConfirmationButtonId).Click();
            DriverInstance().Navigate().GoToUrl(mailAddress);
        }

        public void LoginToGmailNew(string loginName, string loginPassword, string mailAddress)
        {

            DriverInstance().FindElementById(loginGoogleButton).Click();
            DriverInstance().FindElementById(userLoginMailFieldIdNew).SendKeys(testUserName);
            DriverInstance().FindElementByXPath(xPathconfirmLoginIdNew).Click();
            DriverInstance().FindElementByXPath(xPathpasswordFieldIdNew).SendKeys(loginPassword);
            DriverInstance().FindElementByXPath(xPathpasswordConfirmationButtonIdNew).Click();
            DriverInstance().Navigate().GoToUrl(mailAddress);
        }

        public void WaitForElementPresent(By element)
        {
            Wait.Until(ExpectedConditions.ElementExists(element));
        }
    }
}
