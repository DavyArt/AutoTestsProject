using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using UITests.PageObject;

namespace UITests.Tests
{
    [TestFixture]
    class FilterTests : OnePageBaseTest
    {
        [Test, Order(1)]
        public void ChangeTravelCity()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu.ChangeTravelCity("Минск");
        }

        [Test, Order(2)]
        public void ChangeTravelDate()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu
                .DateDropDownOpen()
                .ChangeTravelDate(new DateTime(2021, 6, 24), new DateTime(2021, 6, 30));
        }

        [Test, Order(3)]
        public void ChangeTravelGuests()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu
                .GuestsDropDownOpen()
                .ChangeCountAdults(2)
                .ChangeCountChildren(1)
                .ChangeCountRooms(1)
                .GuestsPageObjectClose()
                .SearchHousing();
        }

        [Test, Order(4)]
        public void CheckFilters()
        {
            SearchPageObject searchPage = new SearchPageObject(_webDriver);

            string city = searchPage.GetCity();

            int countAdults = searchPage.GetCountAdults();
            int countChildrens = searchPage.GetCountChildrens();
            int countRooms = searchPage.GetCountRooms();

            DateTime checkInDate = searchPage.GetCheckInDate();
            DateTime checkOutDate = searchPage.GetCheckOutDate();

            Assert.AreEqual("Минск", city, $"Expected City = Минск, but was: {city}");

            Assert.AreEqual(new DateTime(2021, 06, 24), checkInDate, $"Expected Check-in Date = 24.06.2021, but was: {checkInDate}");
            Assert.AreEqual(new DateTime(2021, 06, 30), checkOutDate, $"Expected Check-out Date = 30.06.2021, but was: {checkOutDate}");
            
            Assert.AreEqual(2, countAdults, $"Expected Adults = 2, but was: {countAdults}");
            Assert.AreEqual(1, countChildrens, $"Expected Childrens = 1, but was: {countChildrens}");
            Assert.AreEqual(1, countRooms, $"Expected Rooms = 1, but was: {countRooms}");
        }
    }
}