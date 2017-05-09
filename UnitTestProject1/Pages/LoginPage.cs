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

       // WebDriverWait wait = new WebDriverWait(DriverInstance(), 10);

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
            Base.WaitForElementLoad(By.Id(loginGoogleButton), 5);
            DriverInstance().FindElementById(loginGoogleButton).Click();
            Base.WaitForElementLoad(By.Id(userLoginMailFieldIdNew), 5);
            DriverInstance().FindElementById(userLoginMailFieldIdNew).SendKeys(testUserName);
            Base.WaitForElementLoad(By.XPath(xPathconfirmLoginIdNew), 5);
            DriverInstance().FindElementByXPath(xPathconfirmLoginIdNew).Click();
            Base.WaitForElementLoad(By.XPath(xPathpasswordFieldIdNew), 5);
            DriverInstance().FindElementByXPath(xPathpasswordFieldIdNew).SendKeys(loginPassword);
            Base.WaitForElementLoad(By.XPath(xPathpasswordConfirmationButtonIdNew), 5);
            DriverInstance().FindElementByXPath(xPathpasswordConfirmationButtonIdNew).Click();
            Base.WaitForElementLoad(By.XPath("//*[@id='gbwa']/div[1]/a"), 5);               // press on menu button
            DriverInstance().FindElementByXPath("//*[@id='gbwa']/div[1]/a").Click();
            Base.WaitForElementLoad(By.XPath("//*[@id='gb23']/span[1]"), 5);            // press on mail button
            DriverInstance().FindElementByXPath("//*[@id='gb23']/span[1]").Click();
        }
    }
}
