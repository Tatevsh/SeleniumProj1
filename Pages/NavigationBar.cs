using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class NavigationBar : BasePage
    {
        IWebElement buttonSignIn => Driver.FindElement(By.XPath("//a[normalize-space()='Sign in']"));
        IWebElement buttonAccount => Driver.FindElement(By.XPath("//a[@title='View my customer account']"));
        IWebElement buttonSignOut => Driver.FindElement(By.XPath("//a[normalize-space()='Sign out']"));

        public void ClickSignIn()
        {
            buttonSignIn.Click();
        }

        public void ClickButtonAccount()
        {
            buttonAccount.Click();
        }

        public void ClickSignOut()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            buttonSignOut.Click();
        }
    }
}
