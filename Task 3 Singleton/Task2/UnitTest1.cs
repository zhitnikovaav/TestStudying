using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Task2.PageObjects;

namespace Task2
{
    public class Tests: BasisTestSetUp
    {
        [TestCase("standard_user", "secret_sauce")]
        [TestCase("locked_out_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        public void LogInTest(string usersLogin, string usersPassword)
        {
            var logInPage = new AuthorizationPageObject(Browser.Driver);
            logInPage.LogIn(usersLogin, usersPassword);
        }

        [Test]
        public void PerformanceGlitchUser()
        {
            var logInPage = new AuthorizationPageObject(Browser.Driver);
            logInPage.LogIn("performance_glitch_user", "secret_sauce");
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElement(By.Id(("react-burger-menu-btn"))));
        }
    }
}