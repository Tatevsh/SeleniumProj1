using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject1.Pages;

namespace TestProject1.Tests
{
    public class SearchTests : BasePage
    {
        [SetUp]
        public void GoToUrl()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            // SearchPage searchPage = new();
            //
            // searchPage.HoverOnMenuDresses();
        }

        [Test]
        public void SomeTest()
        {
            SearchPage searchPage = new();
            
            searchPage.HoverOnMenuDresses();
            searchPage.ClickMenuItemSummerDresses();
            searchPage.CheckNamesToContainDress();
        }
        
    }
}