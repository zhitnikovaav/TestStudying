using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task2.PageObjects
{
    public sealed class AuthorizationPageObject
    {
        private static IWebDriver _webdriver;

        private readonly By _loginInputButton = By.XPath("//input[@name='user-name']");
        private readonly By _passwordInputButton = By.Id("password");
        private readonly By _loginButton = By.Name("login-button");

        private AuthorizationPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public InventoryPageObject LogIn(string login, string password)
        {
            WebDriverWait wait = new WebDriverWait(_webdriver, TimeSpan.FromSeconds(20));
            _webdriver.FindElement(_loginInputButton).SendKeys(login);
            _webdriver.FindElement(_passwordInputButton).SendKeys(password);
            _webdriver.FindElement(_loginButton).Click();
            return InventoryPageObject.GetInstance();
        }
    }
}