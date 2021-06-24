using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class SearchPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _cityInput = By.XPath("//input[@type='search']");
        private readonly By _checkInDate = By.CssSelector("div.sb-dates__col.--checkin-field.xp__date-time div.sb-date-field__display");
        private readonly By _checkOutDate = By.CssSelector("div.sb-dates__col.--checkout-field.xp__date-time div.sb-date-field__display");
        private readonly By _countAdults = By.CssSelector("select[name='group_adults'] option[selected]");
        private readonly By _countChildren = By.CssSelector("select[name='group_children'] option[selected]");
        private readonly By _countRooms = By.CssSelector("select[name='no_rooms'] option[selected]");

        public SearchPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public int GetCountAdults()
        {
            return Convert.ToInt32(_webDriver.FindElement(_countAdults).GetAttribute("value"));
        }

        public int GetCountChildrens()
        {
            return Convert.ToInt32(_webDriver.FindElement(_countChildren).GetAttribute("value"));
        }

        public int GetCountRooms()
        {
            return Convert.ToInt32(_webDriver.FindElement(_countRooms).GetAttribute("value"));
        }

        public DateTime GetCheckInDate()
        {
            return DateTime.Parse(_webDriver.FindElement(_checkInDate).Text);
        }

        public DateTime GetCheckOutDate()
        {
            return DateTime.Parse(_webDriver.FindElement(_checkOutDate).Text);
        }

        public string GetCity()
        {
            return _webDriver.FindElement(_cityInput).GetAttribute("value");
        }
    }
}
