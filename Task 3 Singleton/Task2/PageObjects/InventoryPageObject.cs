using OpenQA.Selenium;

namespace Task2.PageObjects
{
    public class InventoryPageObject
    {
        //private IWebDriver _webdriver;
        
        /*public InventoryPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }*/
        
        private static readonly InventoryPageObject Instance = new InventoryPageObject(); // определяется статическая переменная
                                                      // - ссылка на конкретный экземпляр

        private InventoryPageObject() // приватный конструктор
        {
        }
 
        public static InventoryPageObject GetInstance() //конструктор вызывается для создания объекта,
                                                        //если, конечно, объект отсутствует и равен null.
        {
            {
                return Instance;
            }
        }
    }
}