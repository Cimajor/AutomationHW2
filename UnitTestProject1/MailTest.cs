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
        Base baseInst;
        LoginPageMethods loginPageMethods;
        MailsMethods mailsMethods;

        [TestInitialize]
        public void Start()
        {
            //MailsMethods.CreateTestMessage(MailVariable.smtpUser, MailVariable.smtpPort, MailVariable.smtpServer);
            baseInst = new Base();
            loginPageMethods = new LoginPageMethods(baseInst);
            mailsMethods = new MailsMethods(baseInst);
            baseInst.OpenHomePage();
        }

        [TestMethod]
        public void TestExecution()
        {
            string randomSubject = MailVariable.RandomString(10);
            MailsMethods.CreateTestMessage(MailVariable.smtpUser, MailVariable.smtpPort, MailVariable.smtpServer, randomSubject);
            loginPageMethods.LoginToGmail(LoginPageSelectors.userMailLoginName, LoginPageSelectors.userMailPasswordId);
            mailsMethods.checkMailsSubject(randomSubject);
        }

        [TestCleanup]
        public void TearDown()
        {
            baseInst.CloseBrowser();
        }

    }
}
