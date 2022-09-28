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
        //public AccountCreationPage accountCreationPage => new();
        IWebElement radioButtonMr => Driver.FindElement(By.Id("id_gender1"));
        IWebElement radioButtonMrs => Driver.FindElement(By.Id("id_gender2"));
        IWebElement firstNameField => Driver.FindElement(By.Id("customer_firstname"));
        IWebElement lastNameField => Driver.FindElement(By.Id("customer_lastname"));
        IWebElement passwordField => Driver.FindElement(By.Id("passwd"));
        IList<IWebElement> genderRadioButtons => Driver.FindElements(By.Name("id_gender"));
        IWebElement daysComboBox => Driver.FindElement(By.Name("days"));
        IWebElement monthsComboBox => Driver.FindElement(By.Name("months"));
        IWebElement yearsComboBox => Driver.FindElement(By.Name("years"));
        IWebElement companyField => Driver.FindElement(By.Id("company"));
        IWebElement address1Field => Driver.FindElement(By.Id("address1"));
        IWebElement address2Field => Driver.FindElement(By.Id("address2"));
        IWebElement cityField => Driver.FindElement(By.Id("city"));
        IWebElement stateComboBox => Driver.FindElement(By.Name("id_state"));
        IWebElement postcodeField => Driver.FindElement(By.Id("postcode"));
        IWebElement countryComboBox => Driver.FindElement(By.Id("id_country"));
        IWebElement additionalInfoField => Driver.FindElement(By.Id("other"));
        IWebElement homePhoneField => Driver.FindElement(By.Id("phone"));
        IWebElement mobilePhoneField => Driver.FindElement(By.Id("phone_mobile"));
        IWebElement aliasField => Driver.FindElement(By.Id("alias"));
        IWebElement registerButton => Driver.FindElement(By.Id("submitAccount"));


        public void PickGender()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            int index = ProvideRandomInt(1, genderRadioButtons.Count);
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
            int index = ProvideRandomInt(1, daysOptions.Count);
            daysOptions[index].Click();
        }

        public void PickAMonth()
        {
            SelectElement selectMonths = new SelectElement(monthsComboBox);
            IList<IWebElement> monthsOptions = selectMonths.Options;
            int index = ProvideRandomInt(1, monthsOptions.Count);
            monthsOptions[index].Click();
        }

        public void PickAYear()
        {
            SelectElement selectYears = new SelectElement(yearsComboBox);
            IList<IWebElement> yearsOptions = selectYears.Options;
            int index = ProvideRandomInt(0, yearsOptions.Count);
            yearsOptions[index].Click();
        } 

        public void EnterCompany(string companyName)
        {
            companyField.SendKeys(companyName);
        }

        public void EnterAddress1(string address1)
        {
            address1Field.SendKeys(address1);
        }

        public void EnterAddress2(string address2)
        {
            address2Field.SendKeys(address2);
        }

        public void EnterCity(string city)
        {
            cityField.SendKeys(city);
        }

        public void PickAState()
        {
            SelectElement selectState = new SelectElement(stateComboBox);
            IList<IWebElement> stateOptions = selectState.Options;
            int index = ProvideRandomInt(0, stateOptions.Count);
            stateOptions[index].Click();
        }

        public void EnterPostcode()
        {
            int randomPostcode = ProvideRandomInt(10000, 99999);
            postcodeField.SendKeys(randomPostcode.ToString());
        }

        public void PickACountry()
        {
            SelectElement selectCountry = new SelectElement(countryComboBox);
            //IList<IWebElement> countryOptions = selectCountry.Options;
            selectCountry.SelectByText("United States");
        }

        public void EnterAdditionalInfo(string additionalInfo)
        {
            additionalInfoField.SendKeys(additionalInfo);
        }

        public void EnterHomePhone()
        {
            int homePhone = ProvideRandomInt(1, 1000);
            homePhoneField.SendKeys(homePhone.ToString());
        }

        public void EnterMobilePhone()
        {
            int mobilePhone = ProvideRandomInt(1, 1000);
            mobilePhoneField.SendKeys(mobilePhone.ToString());
        }

        public void EnterAlias(string alias)
        {
            aliasField.SendKeys(alias);
        }

        public void ClickOnRegisterButton()
        {
            registerButton.Click();
        }
    }
}
