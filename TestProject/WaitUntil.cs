using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UITests
{
    public static class WaitUntil
    {
        public static void ShouldLocate(IWebDriver webDriver, string locator)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.UrlContains(locator));
        }

        public static void WaitElement(IWebDriver webDriver, By locator, int sec = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(sec)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(sec)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void WaitSomeInterval(double sec = 20)
        {
            Task.Delay(TimeSpan.FromSeconds(sec)).Wait();
        }
    }
}
