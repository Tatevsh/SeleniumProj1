using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class Tests : BasePage
    {
        [SetUp]
        public void start_Browser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void CreateAnAccountTest()
        {
            HomePage homePage = new();
            LoginPage loginPage = new();
            AccountCreationPage accountCreationPage = new();

            homePage.ClickSignin();
            loginPage.InputEmailCreate();
            loginPage.ClickCreateAnAccount();
            accountCreationPage.PickGender();
            accountCreationPage.EnterFirstName("myFirstName");
            accountCreationPage.EnterLastName("myLastName");
            accountCreationPage.EnterPassword("myPassword");
            accountCreationPage.PickADay();
            accountCreationPage.PickAMonth();
            accountCreationPage.PickAYear();

        }

        [TearDown]
        public void close_Browser()
        {
            //driver.Quit();
        }
    }
}