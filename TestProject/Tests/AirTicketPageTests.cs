using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UITests.PageObject;

namespace UITests.Tests
{
    [TestFixture]
    class AirTicketPageTests : BaseTest
    {
        private readonly string airTicketUrl = "https://booking.kayak.com/";

        [Test]
        public void AirTicketPageIsOpen()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu.OpenAirTicketPage();

            Assert.True(_webDriver.Url.Contains(airTicketUrl), $"Air ticket page not open, actual url: {_webDriver.Url}");
        }
    }
}
