using NUnit.Framework;
using OpenQA.Selenium;
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
        List<IWebElement> radioButtons => (List<IWebElement>)Driver.FindElement(By.XPath("//div[@class='account_creation']//div[@class='clearfix']"));
        WebElement randomCheckbox = radioButtons.get(new Random().NextInt64(1,2));



        public void PickGender()
        {
            WebElement randomCheckbox = checkboxes.get(new Random().nextInt(list.size()));


            Random random = new();
            List<WebElement> radios = Driver.findElements(By.xpath("//input"));
            radios.get(random.NextInt64(radios.size())).click();

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
    }
}
