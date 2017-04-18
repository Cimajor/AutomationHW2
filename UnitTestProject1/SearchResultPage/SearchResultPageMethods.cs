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
    class SearchResultPageMethods : Google
    {
        ChromeDriver chrome;
        public void OpenFewLinks(int linksNumber )   // Open setted numbers of links from serch result  
        {
            int counter = 1;
            for (; counter <= linksNumber; counter++)
            {
                Thread.Sleep(1500);
                chrome.FindElement(By.XPath(SerchResultPageSeletors.LinkNumberSelector(counter))).SendKeys(Keys.Control);
                chrome.SwitchTo().Window(chrome.WindowHandles.Last());
            }

        }
    }
}

