using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class MailVariable
    {
        public static string smtpUser = "illia.test.milevskiy@gmail.com";
        public static int smtpPort = 25;
        public static string smtpServer = "aspmx.l.google.com";
        public static string smtpPassword = "123asdQWE";
        public static string gmailMailUrl = "https://mail.google.com/mail/#inbox";

        public static string RandomString(int size)
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
        public static string randomBody = RandomString(10);

    }
}
