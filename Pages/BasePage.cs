using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class BasePage : DriverHelper
    {
/*        [SetUp]
        public static void OpenBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TearDown]
        public static void CloseBrowser()
        {
            Driver.Quit();
        }*/

        private static IWebDriver Driver;
        public BasePage()
        {
            Driver = DriverHelper.Driver;
        }

        public int ProvideRandomInt(int minValue, int maxValue)
        {
            Random random = new();
            return random.Next(minValue, maxValue);
        }
    }
}
