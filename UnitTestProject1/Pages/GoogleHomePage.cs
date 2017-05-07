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
    class GoogleHomePage : Driver
    {
        public static String searchFieldID = "lst-ib";
        public static String confirmSearchButtonId = "_fZl";
        public static String loginButtonId = "gb_70";
        public static String homePageUrl = "http://www.google.com.ua/";
        public static String homePageMenuButtonId = "http://www.google.com.ua/";

        public void InputInSearchField(String searchInput) // Input something in search fied and press search button
        {
            DriverInstance().FindElementById(searchFieldID).SendKeys(searchInput);
            DriverInstance().FindElementById(confirmSearchButtonId).Click();
        }

        public void ClickOnLoginButton()
        {
            DriverInstance().FindElementById(loginButtonId).Click();
        }
    }
}
