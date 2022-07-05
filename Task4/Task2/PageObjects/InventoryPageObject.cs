using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2.PageObjects
{
    public class InventoryPageObject
    {
        private static IWebDriver _webdriver;
        /*private readonly By filterItemsButton = By.ClassName("product_sort_container");
        private static IWebElement dropDown = _webdriver.FindElement(By.LinkText("Name (A to Z)"));*/

        public InventoryPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        /*public static void ActiveOptionChanging()
        {
          dropDown.Click();
          SelectElement selectOption = new SelectElement(dropDown);
          selectOption.SelectByText("Price (low to high)");
        }*/
    }
}