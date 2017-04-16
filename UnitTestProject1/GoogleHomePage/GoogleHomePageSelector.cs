using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
     class GoogleHomePageSelectors : Google
    {

        public String searchFieldID = "lst - ib";
        public String confirmSearchButtonId = "_fZl";

        public static string homePageUrl()
        {
            String baseUrl = "http://www.google.com.ua/";
            return baseUrl;
        }

        public string SearchFieldID
        {
            get { return searchFieldID; }
        }

        public string ConfirmSearchButtonId
        {
            get { return confirmSearchButtonId; }
        }

    }
}
