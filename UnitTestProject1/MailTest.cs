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
        GoogleHomePageMethods GoogleHomePageMethods = new GoogleHomePageMethods();

        [TestInitialize]
        private void Start()
        {
            MailsMethods.CreateTestMessage(MailVariable.smtpUser, MailVariable.smtpPort, MailVariable.smtpServer);
            GoogleHomePageMethods.OpenHomePage();
        }

        [TestMethod]
        private void TestExecution()
        {
            LoginPageMethods.LoginToGmail(LoginPageSelectors.userMailLoginName, LoginPageSelectors.userMailPasswordId);
        }

        [TestCleanup]
        private void TearDown()
        {
            GoogleHomePageMethods.CloseBrowser();
        }

    }
}
