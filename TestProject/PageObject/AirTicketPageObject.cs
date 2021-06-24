using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class AirTicketPageObject
    {
        private IWebDriver _webDriver;

        public AirTicketPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
