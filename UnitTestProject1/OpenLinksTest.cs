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
        Base baseInst;
        GoogleHomePageMethods googleHomePageMethods;
        SearchResultPageMethods googleSearchResultMethods;

        [TestInitialize]
        public void Start() {
            baseInst = new Base();
            googleHomePageMethods = new GoogleHomePageMethods(baseInst);
            googleSearchResultMethods = new SearchResultPageMethods(baseInst);

            baseInst.OpenHomePage();
        }
        
        [TestMethod]
        public void TestExecution()
        {
            baseInst.waiter();
            googleHomePageMethods.InputInSearchField("Automation testing");
            googleSearchResultMethods.OpenLinks(5);
        }

        [TestCleanup]
        public void TearDown()
        {
            baseInst.CloseBrowser();
        }
    }
}
