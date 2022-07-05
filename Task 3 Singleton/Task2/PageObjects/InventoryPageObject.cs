using OpenQA.Selenium;

namespace Task2.PageObjects
{
    public class InventoryPageObject
    {
        private IWebDriver _webdriver;

        public InventoryPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
    }
}