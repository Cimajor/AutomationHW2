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
    [TestClass]
    public class MailTest
    {
        Driver driver;
        LoginPage loginPage;
        Base bsaeMethods;

        public static string smtpUser = "illia.test.milevskiy@gmail.com";
        public static int smtpPort = 25;
        public static string smtpServer = "aspmx.l.google.com";
        public static string smtpPassword = "123asdQWE";
        public static string gmailMailUrl = "https://mail.google.com/mail/#inbox";

        [TestInitialize]
        public void Start()
        {
            //driver = new Driver();
            loginPage = new LoginPage();
            bsaeMethods = new Base();
            Base.GoToUrl("http://www.google.com.ua/");
        }

        [TestMethod]
        public void TestExecution()
        {
            string randomSubject = Base.RandomString(10);
            Base.CreateTestMessage(smtpUser, smtpPort, smtpServer, randomSubject);
            loginPage.LoginToGmailNew(smtpUser, smtpPassword, gmailMailUrl);
            bsaeMethods.checkMailsSubject(randomSubject);
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.CloseBrowser();
        }

    }
}
