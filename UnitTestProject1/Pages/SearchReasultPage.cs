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
    class SearchResultPage : Driver
    {
        private Base baseIns;

        public static String LinkNumberSelector(int linknumber)
        {
            String linkSelector = (".//*[@id='rso']/div/div/div[" + linknumber + "]/div/div/h3/a");
            return linkSelector;
        }

        public void OpenLinks(int linksNumber)   // Open setted numbers of links from serch result  
        {
            int counter = 1;
            for (; counter <= linksNumber; counter++)
            {
                var et = DriverInstance().FindElement(By.XPath(LinkNumberSelector(counter)));
                et.SendKeys(Keys.Control + Keys.Return);
                DriverInstance().SwitchTo().Window(DriverInstance().WindowHandles.First());
            }

        }
    }
}

