using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task2
{
    public class Browser
    {
        
        private static IWebDriver _driver = new ChromeDriver();
        private static readonly object Threadlock = new object();


        public static IWebDriver Driver
        {
            get
            {

                lock (Threadlock)
                {
                    if (_driver == null)
                        _driver = new ChromeDriver();

                    return _driver;
                }
            }
        }
    }
}