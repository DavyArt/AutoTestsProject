using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.PageObject
{
    class GuestsPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _guestsDropDown = By.XPath("//div[@class='xp__input-group xp__guests']");
        private readonly By _countAdults = By.CssSelector("div.sb-group__field.sb-group__field-adults span.bui-stepper__display");
        private readonly By _countChildren = By.CssSelector("div.sb-group__field.sb-group-children  span.bui-stepper__display");
        private readonly By _countRooms = By.CssSelector("div.sb-group__field.sb-group__field-rooms span.bui-stepper__display");
        private readonly By _descAdultsButton = By.CssSelector("div.sb-group__field.sb-group__field-adults button[data-bui-ref='input-stepper-subtract-button']");
        private readonly By _ascAdultsButton = By.CssSelector("div.sb-group__field.sb-group__field-adults button[data-bui-ref='input-stepper-add-button']");
        private readonly By _descChildrenButton = By.CssSelector("div.sb-group__field.sb-group-children  button[data-bui-ref='input-stepper-subtract-button']");
        private readonly By _ascChildrenButton = By.CssSelector("div.sb-group__field.sb-group-children  button[data-bui-ref='input-stepper-add-button']");
        private readonly By _descRoomsButton = By.CssSelector("div.sb-group__field.sb-group__field-rooms  button[data-bui-ref='input-stepper-subtract-button']");
        private readonly By _ascRoomsButton = By.CssSelector("div.sb-group__field.sb-group__field-rooms  button[data-bui-ref='input-stepper-add-button']");

        public GuestsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public GuestsPageObject ChangeCountAdults(int count)
        {
            int countAdults = Convert.ToInt32(_webDriver.FindElement(_countAdults).Text);

            if (count > countAdults)
            {
                for (; countAdults < count; countAdults++)
                {
                    _webDriver.FindElement(_ascAdultsButton).Click();
                }
            }
            else if (count < countAdults)
            {
                for (; countAdults > count; countAdults--)
                {
                    _webDriver.FindElement(_descAdultsButton).Click();
                }
            }

            return this;
        }

        public GuestsPageObject ChangeCountChildren(int count)
        {
            int countChildren = Convert.ToInt32(_webDriver.FindElement(_countChildren).Text);

            if (count > countChildren)
            {
                for (; countChildren < count; countChildren++)
                {
                    _webDriver.FindElement(_ascChildrenButton).Click();
                }
            }
            else if (count < countChildren)
            {
                for (; countChildren > count; countChildren--)
                {
                    _webDriver.FindElement(_descChildrenButton).Click();
                }
            }

            return this;
        }

        public GuestsPageObject ChangeCountRooms(int count)
        {
            int countRooms = Convert.ToInt32(_webDriver.FindElement(_countRooms).Text);

            if (count > countRooms)
            {
                for (; countRooms < count; countRooms++)
                {
                    _webDriver.FindElement(_ascRoomsButton).Click();
                }
            }
            else if (count < countRooms)
            {
                for (; countRooms > count; countRooms--)
                {
                    _webDriver.FindElement(_descRoomsButton).Click();
                }
            }

            return this;
        }

        public MainMenuPageObject GuestsPageObjectClose()
        {
            _webDriver.FindElement(_guestsDropDown).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}
