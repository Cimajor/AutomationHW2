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
        [TestMethod]
        public void TestExecution()
        {
            MailsMethods.SendMail(MailVariable.smtpUser, MailVariable.smtpPort, MailVariable.smtpServer);
        }

    }
}
