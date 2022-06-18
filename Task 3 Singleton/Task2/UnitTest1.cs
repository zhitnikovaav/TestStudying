using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using Task2.PageObjects;

namespace Task2
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new EdgeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
        }

        [TestCase("standard_user", "secret_sauce")]
        [TestCase("locked_out_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        [TestCase("performance_glitch_user", "secret_sauce")]
        public void LogInTest(string usersLogin, string usersPassword)
        {
            var logInPage = AuthorizationPageObject.;
            logInPage.LogIn(usersLogin, usersPassword);
        }

        [Test]
        public void PerformanceGlitchUser(string usersLogin, string usersPassword)
        {
            
        }
        
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}