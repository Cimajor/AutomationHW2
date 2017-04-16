using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Net.Mail;
using System.Net;

namespace UnitTestProject1
{
    class MailsMethods
    {
        public static void CreateTestMessage(string user, int port, string server)
        {
            string to = user;
            string from = user;
            string subject = "Using the new SMTP client.";
            string body = @"Using this new feature, you can send an e-mail message from an application very easily.";
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient(server, port);
            // Credentials are necessary if the server requires the client 
            // to authenticate before it will send e-mail on the client's behalf.
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

        void CheckMail()
        {

        }
    }
}
