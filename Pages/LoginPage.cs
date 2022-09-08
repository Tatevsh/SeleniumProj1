using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
    
namespace TestProject1.Pages
{
    public class LoginPage : BasePage
    {
        IWebElement emailFieldCreate => Driver.FindElement(By.Id("email_create"));
        IWebElement buttonCreateAnAccount => Driver.FindElement(By.Id("SubmitCreate"));
        IWebElement emailFieldSignin => Driver.FindElement(By.Id("email"));
        IWebElement passwordFieldSignin => Driver.FindElement(By.Id("passwd"));
        IWebElement buttonLogin => Driver.FindElement(By.Id("login"));

        public void InputEmailCreate()
        {
            Random randomGenerator = new Random();
            long randomInt = randomGenerator.NextInt64(1000);
            emailFieldCreate.SendKeys("username" + randomInt + "@tatevs.tests");
        }

        public void ClickCreateAnAccount()
        {
            buttonCreateAnAccount.Click();
        }

        public void InputEmailAndPasswordSignin (string email, string password)
        {
            emailFieldSignin.SendKeys(email);
            passwordFieldSignin.SendKeys(password);
        }

        public void ClickLogin()
        {
            buttonLogin.Click();
        }
    }
}