using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace UnitTestProject1
{
    public class Base
    {

        public void waiter()
        {
            const int defaultWait = 4;
            WebDriverWait Wait = new WebDriverWait(Driver.DriverInstance(), TimeSpan.FromSeconds(defaultWait));
        }


        public static void GoToUrl(String baseUrl)    //Open Google home page
        {
            ChromeDriver drive = Driver.DriverInstance();
            drive.Navigate().GoToUrl(baseUrl);
            drive.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public static string smtpUser = "illia.test.milevskiy@gmail.com";
        public static int smtpPort = 25;
        public static string smtpServer = "aspmx.l.google.com";
        public static string smtpPassword = "123asdQWE";
        public static string gmailMailUrl = "https://mail.google.com/mail/#inbox";

        public static string RandomString(int size)  //Create random string
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public static string randomBody = RandomString(10); //Call random string long - 10

        public static void CreateTestMessage(string user, int port, string server, string rundomSubject) // Create and send test message with random subject on test mail
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

        public void checkMailsSubject(string randomSubject) // Check if test presented on page 
        {
            Assert.IsTrue(Driver.DriverInstance().PageSource.Contains(randomSubject));
        }
    }
}
