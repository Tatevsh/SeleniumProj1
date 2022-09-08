using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class BasePage : DriverHelper
    {
        private static IWebDriver Driver;
        public BasePage()
        {
            Driver = DriverHelper.Driver;
        }
    }
}
