using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;

namespace TestProject1.Pages
{
    public class AuthenticationPage : BasePage
    {
        IWebElement emailFieldCreate => Driver.FindElement(By.Id("email_create"));
        IWebElement buttonCreateAnAccount => Driver.FindElement(By.Id("SubmitCreate"));
        IWebElement emailFieldSignin => Driver.FindElement(By.Id("email"));
        IWebElement passwordFieldSignin => Driver.FindElement(By.Id("passwd"));
        IWebElement buttonSignin => Driver.FindElement(By.Id("SubmitLogin"));

        public void InputEmailCreate()
        {
            int randomInt = ProvideRandomInt(0, 1000);
            StringBuilder sb = new();
            sb.Append("username");
            sb.Append(randomInt.ToString());
            sb.Append("@tatevs.tests");
            emailFieldCreate.SendKeys(sb.ToString());

            //Alternative 
            //int randomInt = randomProvider(0, 1000);
            //emailFieldCreate.SendKeys("username" + randomInt + "tatevs.tests");
        }

        public void ClickCreateAnAccount()
        {
            buttonCreateAnAccount.Click();
        }

        public void InputEmailAndPasswordSignIn (string email, string password)
        {
            emailFieldSignin.SendKeys(email);
            passwordFieldSignin.SendKeys(password);
        }

        public void ClickSignIn()
        {
            buttonSignin.Click();
        }
    }
}