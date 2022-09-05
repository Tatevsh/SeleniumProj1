using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TestProject1.Pages;

namespace TestProject1
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void start_Browser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void SigninTest()
        {
            Driver.Navigate().GoToUrl("https://www.sololearn.com/home");

            HomePage homePage = new();
            SigninPage signinPage = new();

            homePage.ClickLogin();
            signinPage.EnterEmailAndPassword("tatev_test@sololearn.com", "MyComplesPass1!");
            signinPage.ClickSignin();

            /*var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));  //Wait until email field appears
            wait.Until(drv => drv.FindElement(By.Id("email")));*/                 

        }

/*        [Test]
        public void RegisterFromHomepage()
        {
            Driver.Navigate().GoToUrl(test_url);

            Driver.FindElement(By.XPath("//*[text()='Register']")).Click(); //Register Button on Homepage

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.FindElement(By.Id("email")));

            Driver.FindElement(By.Id("email")).SendKeys("tatev_test@sololearn.com");

            Driver.FindElement(By.Id("password")).SendKeys("MyComplexPass1!");

            Driver.FindElement(By.XPath("//*[text()='Sign in']")).Click();
        }*/

        [TearDown]
        public void close_Browser()
        {
            //driver.Quit();
        }
    }
}