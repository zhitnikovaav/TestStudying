using System;
using OpenQA.Selenium;

namespace Task2.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webdriver;

        private readonly By _loginInputButton = By.XPath("//input[@name='user-name']");
        private readonly By _passwordInputButton = By.XPath("//input[@name = 'password']");
        private readonly By _loginButton = By.XPath("//input[@name = 'login-button']");

        public AuthorizationPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public InventoryPageObject LogIn(string login, string password)
        {
            _webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _webdriver.FindElement(_loginInputButton).SendKeys(login);
            _webdriver.FindElement(_passwordInputButton).SendKeys(password);
            _webdriver.FindElement(_loginButton).Click();
            return new InventoryPageObject(_webdriver);
        }
    }
}