﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class HomePage : BasePage
    {
        IWebElement buttonSignin => Driver.FindElement(By.XPath("//a[normalize-space()='Sign in']"));

        public void ClickSignin()
        {
            buttonSignin.Click();
        }
    }
}
