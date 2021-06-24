using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _currencyButton = By.XPath("//button[@data-modal-header-async-type='currencyDesktop']");
        private readonly By _languageButton = By.XPath("//button[@data-modal-id='language-selection']");
        private readonly By _airTicketButton = By.XPath("//a[@data-decider-header = 'flights']");
        private readonly By _signInButton = By.LinkText("Войти в аккаунт");
        private readonly By _userDropDown = By.XPath("//a[contains(@href, 'mydashboard')]");
        private readonly By _dateDropDown = By.XPath("//div[@class='xp__dates-inner']");
        private readonly By _cityInput = By.XPath("//input[@type='search']");
        private readonly By _guestsDropDown = By.XPath("//div[@class='xp__input-group xp__guests']");
        private readonly By _searchButton = By.XPath("//button[@class='sb-searchbox__button ']");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public CurrencyPageObject Currency()
        {
            _webDriver.FindElement(_currencyButton).Click();

            return new CurrencyPageObject(_webDriver);
        }

        public LanguagePageObject Language()
        {
            _webDriver.FindElement(_languageButton).Click();

            return new LanguagePageObject(_webDriver);
        }

        public string GetActualCurrency()
        {
            return _webDriver.FindElement(_currencyButton).Text;
        }

        public string GetActualLanguage()
        {
            return _webDriver.FindElement(_languageButton).Text;
        }

        public AirTicketPageObject OpenAirTicketPage()
        {
            _webDriver.FindElement(_airTicketButton).Click();

            return new AirTicketPageObject(_webDriver);
        }

        public AuthPageObject SignIn()
        {
            _webDriver.FindElement(_signInButton).Click();

            return new AuthPageObject(_webDriver);
        }

        public bool CheckAuth()
        {
            try
            {
                _webDriver.FindElement(_userDropDown);

                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

        public DateTravelPageObject DateDropDownOpen()
        {
            _webDriver.FindElement(_dateDropDown).Click();

            return new DateTravelPageObject(_webDriver);
        }

        public GuestsPageObject GuestsDropDownOpen()
        {
            _webDriver.FindElement(_guestsDropDown).Click();

            return new GuestsPageObject(_webDriver);
        }

        public MainMenuPageObject ChangeTravelCity(string city)
        {
            _webDriver.FindElement(_cityInput).SendKeys(city);

            return this;
        }

        public SearchPageObject SearchHousing()
        {
            _webDriver.FindElement(_searchButton).Click();

            return new SearchPageObject(_webDriver);
        }
    }
}
