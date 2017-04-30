using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;

namespace UnitTestProject1
{
    class MailsMethods
    {
        private Base baseIns;
        private ChromeDriver chrome;

        public MailsMethods(Base baseIns)
        {
            this.baseIns = baseIns;
            chrome = baseIns.getChromeDriver();
        }

        public static void CreateTestMessage(string user, int port, string server, string rundomSubject)
        {
            string to = user;
            string from = user;
            string subject = rundomSubject;
            string body = @"Using this new feature, you can send an e-mail message from an application very easily.";
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient(server, port);

            client.Credentials = CredentialCache.DefaultNetworkCredentials;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage1(): {0}",
                            ex.ToString());
            }
        }
        public void checkMailsSubject(string randomSubject)
        {
            //chrome.FindElementById(":3f").Text.Equals("Using the new SMTP client.");
            Assert.IsTrue(chrome.PageSource.Contains(randomSubject));
        }
    }
}
