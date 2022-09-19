using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class RegisterTests : BasePage
    {
        [SetUp]
        public void GoToUrl()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            HomePage homePage = new();

            homePage.ClickSignin();
        }

        [Test]
        public void CreateAnAccountTest()
        {
            AuthenticationPage authenticationPage = new();
            AccountCreationPage accountCreationPage = new();

            authenticationPage.InputEmailCreate();
            authenticationPage.ClickCreateAnAccount();
            accountCreationPage.PickGender();
            accountCreationPage.EnterFirstName("myFirstName");
            accountCreationPage.EnterLastName("myLastName");
            accountCreationPage.EnterPassword("myPassword");
            accountCreationPage.PickADay();
            accountCreationPage.PickAMonth();
            accountCreationPage.PickAYear();
            accountCreationPage.EnterCompany("company");
            accountCreationPage.EnterAddress1("address1");
            accountCreationPage.EnterAddress2("address2");
            accountCreationPage.EnterCity("city");
            accountCreationPage.PickACountry();
            accountCreationPage.EnterPostcode();
            accountCreationPage.EnterAdditionalInfo("additionalInfo");
            accountCreationPage.EnterHomePhone();
            accountCreationPage.EnterMobilePhone();
            accountCreationPage.EnterAlias("alias");
            accountCreationPage.PickAState();
            accountCreationPage.ClickOnRegisterButton();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}