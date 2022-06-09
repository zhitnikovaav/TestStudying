using NUnit.Framework;
using OpenQA.Selenium;

namespace Task2
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _loginInputButton = By.XPath("//input[@name='user-name']");
        private readonly By _passwordInputButton = By.XPath("//input[@name = 'password']");
        private readonly By _loginButton = By.XPath("//input[@name = 'login-button']");
            [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [TestCase("standard_user", "secret_sauce")]
        [TestCase("locked_out_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        [TestCase("performance_glitch_user", "secret_sauce")]
        public void LogInTest(string usersLogin, string usersPassword)
        {
            var login = driver.FindElement(_loginInputButton);
            login.SendKeys(usersLogin);
            
            var password = driver.FindElement(_passwordInputButton);
            password.SendKeys(usersPassword);

            var loginButton = driver.FindElement(_loginButton);
            loginButton.Click();
        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}