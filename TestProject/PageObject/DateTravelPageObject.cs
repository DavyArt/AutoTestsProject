using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class DateTravelPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _dateDropDown = By.XPath("//div[@class='xp__dates-inner']");

        public DateTravelPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public DateTravelPageObject ChangeTravelDate(DateTime checkDate, DateTime depDate)
        {
            By checkInButton = By.XPath($"//td[@data-date='{checkDate.ToString("yyyy-MM-dd")}']");
            By checkOutButton = By.XPath($"//td[@data-date='{depDate.ToString("yyyy-MM-dd")}']");

            _webDriver.FindElement(checkInButton).Click();
            _webDriver.FindElement(checkOutButton).Click();

            return this;
        }

        public MainMenuPageObject DateTravelPageObjectClose()
        {
            _webDriver.FindElement(_dateDropDown).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}
