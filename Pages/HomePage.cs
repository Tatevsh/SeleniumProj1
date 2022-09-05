using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement buttonLogin => Driver.FindElement(By.XPath("//*[text()='Log in']"));
        public void ClickLogin() => buttonLogin.Click();
    }
}
