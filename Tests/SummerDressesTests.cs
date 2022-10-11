using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class SummerDressesTests : BasePage
    {
        [SetUp]
        public void GoToUrl()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            HomePage homePage = new();

            homePage.HoverOnMenuDresses();
            homePage.ClickMenuItemSummerDresses();
        }

        [Test]
        public void CheckUrl()
        {
            Assert.That(Driver.Url, Is.EqualTo("http://automationpractice.com/index.php?id_category=11&controller=category"));
        }
        
        [Test]
        public void CheckItemCount()
        {
            SummerDressesPage summerDressesPage = new();

            Assert.That(summerDressesPage.ItemsCount(), Is.EqualTo(3));
        }

        [Test]
        public void CheckNamesToContainDress()
        {
            SummerDressesPage summerDressesPage = new();
            
            foreach (var item in summerDressesPage.ItemsNames())
            {
                Assert.That(item, Does.Contain("dress"));
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}