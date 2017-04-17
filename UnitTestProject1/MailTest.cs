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
    public class MailTest
    {
        LoginPageMethods LoginPageMethods = new LoginPageMethods();
        GoogleHomePageMethods GoogleHomePageMethods = new GoogleHomePageMethods();

        [TestInitialize]
        public void Start()
        {
            //MailsMethods.CreateTestMessage(MailVariable.smtpUser, MailVariable.smtpPort, MailVariable.smtpServer);
            LoginPageMethods.OpenHomePage();
        }

        [TestMethod]
        public void TestExecution()
        {
            LoginPageMethods.LoginToGmail(LoginPageSelectors.userMailLoginName, LoginPageSelectors.userMailPasswordId);
        }

        [TestCleanup]
        public void TearDown()
        {
            GoogleHomePageMethods.CloseBrowser();
        }

    }
}
