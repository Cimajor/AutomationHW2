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
     class GoogleHomePageMethods //: Base
    {
        private Base baseIns;
        
        public GoogleHomePageMethods(Base baseIns)//:base()    //Open Google home page
        {
            this.baseIns = baseIns;
        }

        public void InputInSearchField(String searchInput) // Input something in search fied and press search button
        {
            baseIns.getChromeDriver().FindElementById(GoogleHomePageSelectors.searchFieldID).SendKeys(searchInput);
            baseIns.getChromeDriver().FindElementById(GoogleHomePageSelectors.confirmSearchButtonId).Click();
        }

        public void ClickOnLoginButton()
        {
            baseIns.getChromeDriver().FindElementById(GoogleHomePageSelectors.loginButtonId).Click();
        }
    }
}
