using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UITests.PageObject;

namespace UITests.Tests
{
    [TestFixture]
    class ChangeOfCurrencyAndLanguageTests : BaseTest
    {
        [Test]
        public void ChangeCurrency()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu
                .Currency()
                .ChangeToUSD();

            var actualCurrency = mainMenu.GetActualCurrency();

            Assert.True(actualCurrency.Contains("USD"), $"Current not USD, {actualCurrency}");
        }

        [Test]
        public void ChangeLanguage()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu
                .Language()
                .ChangeToENG();

            var actualLanguage = mainMenu.GetActualLanguage();

            Assert.True(actualLanguage.Contains("English"), $"Language not ENG, {actualLanguage}");
        }
    }
}
