using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1.Pages
{
    public class SigninPage : DriverHelper
    {
        IWebElement emailField => Driver.FindElement(By.Id("email"));
        IWebElement passwordField => Driver.FindElement(By.Id("password"));
        IWebElement buttonSignin => Driver.FindElement(By.XPath("//*[text()='Sign in']"));

        public void EnterEmailAndPassword (string email, string password)
        {
            emailField.SendKeys(email);
            passwordField.SendKeys(password);
        }

        public void ClickSignin()
        {
            buttonSignin.Click();
        }

    }
}