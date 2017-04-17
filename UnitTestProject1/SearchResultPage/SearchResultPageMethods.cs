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
    class SearchResultPageMethods : Google

    {
        ChromeDriver chrome;

        public void OpenFewLinks(int linksNumber)   // Open setted numbers of links from serch result  
        {
            int counter = 1;

#pragma warning disable CS0618 // Тип или член устарел
            chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Actions action = new Actions(chrome);

            for (; counter <= linksNumber; counter++)
            {
                IWebElement body = chrome.FindElement(By.XPath(SerchResultPageSeletors.LinkNumberSelector(counter)));
                chrome.FindElementByXPath(SerchResultPageSeletors.LinkNumberSelector(counter)).Click();
                Thread.Sleep(1500);
                action.KeyDown(Keys.Control).MoveToElement(body).Click().Perform();
            }
            chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

#pragma warning restore CS0618 // Тип или член устаре

        }
    }
}
