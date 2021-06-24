using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UITests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;
        
        protected readonly string _mainUrl = "https://www.booking.com/";

        [OneTimeSetUp]
        protected void OneTimeSetUp()
        {
            _webDriver = new ChromeDriver();
        }

        [TearDown]
        protected void TearDown()
        {
            //_webDriver.Quit();
        }

        [SetUp]
        protected void Setup()
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_mainUrl);

            WaitUntil.ShouldLocate(_webDriver, _mainUrl);
        }
    }
}