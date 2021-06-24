using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.Tests
{
    class OnePageBaseTest
    {
        protected IWebDriver _webDriver;

        protected readonly string _mainUrl = "https://www.booking.com/";

        [OneTimeSetUp]
        protected void OneTimeSetUp()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_mainUrl);

            WaitUntil.ShouldLocate(_webDriver, _mainUrl);
        }

        [TearDown]
        protected void TearDown()
        {
            //_webDriver.Quit();
        }
    }
}
