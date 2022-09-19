using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class SignOutTests : BasePage
    {
        [SetUp]
        public void GoToUrl()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            HomePage homePage = new();
            AuthenticationPage authenticationPage = new();

            homePage.ClickSignin();
            authenticationPage.InputEmailAndPasswordSignIn("username397@tatevs.tests", "myPassword");
            authenticationPage.ClickSignIn();
        }

        [Test]
        public void SignOutTest()
        {
            NavigationBar navigationBar = new();

            navigationBar.ClickSignOut();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
