using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Driver
    {
        private static ChromeDriver driverInstance;

        public Driver()
        {

        }

        public static ChromeDriver DriverInstance()
        {
            if (driverInstance == null)
            {
                driverInstance = new ChromeDriver("C:\\");
            }
            return driverInstance;
        }

        public static void CloseBrowser()
        {
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance = null;
            }
        }
    }
}
