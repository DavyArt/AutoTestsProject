using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UITests.PageObject;

namespace UITests.Tests
{
    [TestFixture]
    class AuthPageTests : BaseTest
    {
        private readonly string login = "dsdf.dsfs.97@bk.ru";
        private readonly string password = "uR1UPY%pyaa2";

        [Test]
        public void LoginUser()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(_webDriver);

            mainMenu
                .SignIn()
                .Login(login, password);

            WaitUntil.ShouldLocate(_webDriver, _mainUrl);

            Assert.IsTrue(mainMenu.CheckAuth(), "Authorization failed");
        }
    }
}
