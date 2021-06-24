using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class AuthPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _usernameInput = By.XPath("//input[@id='username']");
        private readonly By _passwordInput = By.XPath("//input[@id='password']");
        private readonly By _continueButton = By.XPath("//button[@class='bui-button bui-button--large bui-button--wide']");
        private readonly By _loginButton = By.XPath("//button[@class='bui-button bui-button--large bui-button--wide']");

        public AuthPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_usernameInput).SendKeys(login);
            _webDriver.FindElement(_continueButton).Click();

            WaitUntil.WaitElement(_webDriver, _passwordInput);

            _webDriver.FindElement(_passwordInput).SendKeys(password);
            _webDriver.FindElement(_loginButton).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}
