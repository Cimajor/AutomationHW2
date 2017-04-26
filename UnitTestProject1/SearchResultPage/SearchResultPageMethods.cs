using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Linq;

namespace UnitTestProject1
{
    class SearchResultPageMethods// : Base
    {
        Base baseIns;

        public SearchResultPageMethods(Base baseIns) {
            this.baseIns = baseIns;
        }

        public void OpenLinks(int linksNumber )   // Open setted numbers of links from serch result  
        {
            int counter = 1;
            ChromeDriver chrome = baseIns.getChromeDriver();

            for (; counter <= linksNumber; counter++)
            {
                chrome.FindElement(By.XPath(SerchResultPageSeletors.LinkNumberSelector(counter))).SendKeys(Keys.Control);
                chrome.SwitchTo().Window(chrome.WindowHandles.Last());
            }

        }
    }
}

