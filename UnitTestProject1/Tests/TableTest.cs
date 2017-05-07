//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Collections.Generic;

//namespace UnitTestProject1
//{
//    class TableTest
//    {
//        Base baseInst;


//        [TestInitialize]
//        public void Start()
//        {
//            baseInst = new Base();
//            baseInst.OpenGoogleHomePage();
//        }

//        [TestMethod]
//        public void TestExecution()
//        {
//            IWebElement TempElement;
//            baseInst.GoTo("http://www.machtested.com/");
//            baseInst.getChromeDriver().FindElement(By.XPath("//a[contains(@href,'selenium-course')]")).Click();
//            TempElement = baseInst.getChromeDriver().FindElement(By.ClassName("MsoNormalTable"));
//            IList<IWebElement> ListOfElements = TempElement.FindElements(By.TagName("tr"));

//            foreach (var item in ListOfElements)
//            {
//                Console.WriteLine(item.Text.ToString());
                
//            }

//        }

//        [TestCleanup]
//        public void TearDown()
//        {
//            baseInst.CloseBrowser();
//        }
//    }
//}
