using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Task2
{
    public class BasisTestSetUp
    {
        [SetUp]
        public void Setup()
        {
            Browser.Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Browser.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.Driver.Manage().Window.Maximize();
        }
        
        [TearDown]
        public void TearDown()
        {
            Browser.Driver.Close();
        }
    }
}