using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
     class GoogleHomePageSelectors : Base
    {
        public static String searchFieldID = "lst-ib";
        public static String confirmSearchButtonId = "_fZl";
        public static String loginButtonId = "gb_70";
        public static String homePageUrl = "http://www.google.com.ua/";
        public static String homePageMenuButtonId = "http://www.google.com.ua/";
    }
}
