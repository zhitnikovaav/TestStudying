using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2.PageObjects
{
    public sealed class AuthorizationPageObject
    {
        private readonly IWebDriver _webdriver;

        private readonly By _loginInputButton = By.XPath("//input[@name='user-name']");
        private readonly By _passwordInputButton = By.Id("password");
        private readonly By _loginButton = By.XPath("//input[@name = 'login-button']");

        public AuthorizationPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public InventoryPageObject LogIn(string login, string password)
        {
            _webdriver.FindElement(_loginInputButton).SendKeys(login);
            _webdriver.FindElement(_passwordInputButton).SendKeys(password);
            _webdriver.FindElement(_loginButton).Click();
            return new InventoryPageObject(_webdriver);
        }
    }
}