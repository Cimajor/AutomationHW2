using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Net.Mail;


namespace UnitTestProject1
{
    class MailsMethods
    {
        public static void SendMail(string SmtpUser, int smtpPort, string smtpServer ) {
            MailMessage mail = new MailMessage(SmtpUser, SmtpUser);
            SmtpClient client = new SmtpClient();
            client.Port = smtpPort;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = smtpServer;
            mail.Subject = "Check it";
            mail.Body = "this is my test email body";
            client.Send(mail);
        }

        void CheckMail()
        {

        }
    }
}
