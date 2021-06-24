using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class LanguagePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _selectENGButton = By.XPath("//a[@data-lang='en-us']");

        public LanguagePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void ChangeToENG()
        {
            _webDriver.FindElement(_selectENGButton).Click();
        }
    }
}
