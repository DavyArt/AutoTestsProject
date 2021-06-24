using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class CurrencyPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _selectUSDButton = By.XPath("//a[@data-modal-header-async-url-param='changed_currency=1;selected_currency=USD;top_currency=1']");

        public CurrencyPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void ChangeToUSD()
        {
            _webDriver.FindElement(_selectUSDButton).Click();
        }
    }
}
