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
    [TestClass]
    public class OpenLinksTest
    {
        Driver driver;
        GoogleHomePage googleHomePageMethods;
        SearchResultPage googleSearchResultMethods;

        [TestInitialize]
        public void Start() {
          //  baseInst = new Base();
            googleHomePageMethods = new GoogleHomePage();
            googleSearchResultMethods = new SearchResultPage();
            driver = new Driver();
            Base.GoToUrl("http://www.google.com.ua/");
        }
        
        [TestMethod]
        public void TestExecution()
        {
            googleHomePageMethods.InputInSearchField("Automation testing");
            googleSearchResultMethods.OpenLinks(5);
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.CloseBrowser();
        }
    }
}
