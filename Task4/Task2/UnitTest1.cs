using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using Task2.PageObjects;

namespace Task2
{
    public class Tests
    {
        private static IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
        }

        [TestCase("standard_user", "secret_sauce")]
        [TestCase("locked_out_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        public void LogInTest(string usersLogin, string usersPassword)
        {
            var logInPage = new AuthorizationPageObject(_driver);
            logInPage.LogIn(usersLogin, usersPassword);
        }

        [TestCase("performance_glitch_user", "secret_sauce")]
        public void PerformanceGlitchUserTest(string usersLogin, string usersPassword)
        {
            var logInPage = new AuthorizationPageObject(_driver);
            logInPage.LogIn(usersLogin, usersPassword);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElement(By.Id(("react-burger-menu-btn"))));
        }

        //[Test]
       /* public void ActiveOptionChangingTest()
        {
            var logInPage = new AuthorizationPageObject(_driver);
            logInPage.LogIn("standard_user", "secret_sauce");
            var inventoryPage = new InventoryPageObject(_driver);
            InventoryPageObject.ActiveOptionChanging();

            Assert.Equals(By.LinkText("$7.99"), By.LinkText("$7.99"));
        }*/

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}