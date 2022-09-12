using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Pages
{
    public class AccountCreationPage : BasePage
    {
        IWebElement radioButtonMr => Driver.FindElement(By.Id("id_gender1"));
        IWebElement radioButtonMrs => Driver.FindElement(By.Id("id_gender2"));
        IWebElement firstNameField => Driver.FindElement(By.Id("customer_firstname"));
        IWebElement lastNameField => Driver.FindElement(By.Id("customer_lastname"));
        IWebElement passwordField => Driver.FindElement(By.Id("passwd"));
        IList<IWebElement> genderRadioButtons => Driver.FindElements(By.Name("id_gender"));
        IWebElement daysComboBox => Driver.FindElement(By.Name("days"));
        IWebElement monthsComboBox => Driver.FindElement(By.Name("months"));
        IWebElement yearsComboBox => Driver.FindElement(By.Name("years"));


        public void PickGender()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Random randomGenerator = new();
            int index = randomGenerator.Next(1, genderRadioButtons.Count);
            genderRadioButtons[index].Click();
        }
       
        public void ClickRadioButtonMr()
        {
            radioButtonMr.Click();
        }

        public void ClickRadioButtonMrs()
        {
            radioButtonMrs.Click();
        }

        public void EnterFirstName(string firstName)
        {
            firstNameField.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            lastNameField.SendKeys(lastName);
        }
        
        public void EnterPassword(string password)
        {
            passwordField.SendKeys(password);
        }

        public void PickADay()
        {
            SelectElement selectDays = new SelectElement(daysComboBox);
            IList<IWebElement> daysOptions = selectDays.Options;
            Random randomGenerator = new();
            int index = randomGenerator.Next(1, daysOptions.Count);
            daysOptions[index].Click();
        }

        public void PickAMonth()
        {
            SelectElement selectMonths = new SelectElement(monthsComboBox);
            IList<IWebElement> monthsOptions = selectMonths.Options;
            Random randomGenerator = new();
            int index = randomGenerator.Next(1, monthsOptions.Count);
            monthsOptions[index].Click();
        }

        public void PickAYear()
        {
            SelectElement selectYears = new SelectElement(yearsComboBox);
            IList<IWebElement> yearsOptions = selectYears.Options;
            Random randomGenerator = new();
            int index = randomGenerator.Next(1, yearsOptions.Count);
            yearsOptions[index].Click();
        }
    }
}
