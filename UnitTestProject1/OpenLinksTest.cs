﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class OpenLinksTest
    {
        GoogleHomePageMethods GoogleHomePageMethods = new GoogleHomePageMethods();
        SearchResultPageMethods GoogleSearchResultMethods = new SearchResultPageMethods();

        [TestInitialize]
        public void Start() {
            GoogleHomePageMethods.OpenHomePage();
        }
        
        [TestMethod]
        public void TestExecution()
        {
            GoogleHomePageMethods.InputInSearchField("Automation testing");
            GoogleSearchResultMethods.OpenFewLinks(5);
        }

        [TestCleanup]
        public void TearDown()
        {
            GoogleHomePageMethods.CloseBrowser();
        }
    }
}