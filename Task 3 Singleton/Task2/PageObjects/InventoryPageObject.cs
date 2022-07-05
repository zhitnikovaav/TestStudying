using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2.PageObjects
{
    public class InventoryPageObject
    {
        private static IWebDriver _webdriver;

        public InventoryPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        private static readonly By _addToCart = By.Name("add-to-cart-sauce-labs-backpack");
        private static readonly By _shoppingCart = By.XPath("//*[@id='shopping_cart_container']");

        public static void AddToCart()
        {
            _webdriver.FindElement(_addToCart).Click();
        }
    }
}