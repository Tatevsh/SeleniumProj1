using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace TestProject1.Pages
{
    public class HomePage : BasePage
    {
        IWebElement buttonSignin => Driver.FindElement(By.XPath("//a[normalize-space()='Sign in']"));
        IWebElement menuDresses => Driver.FindElement(By.XPath("(//a[@title='Dresses'][normalize-space()='Dresses'])[2]"));
        IWebElement menuItemSummerDresses = Driver.FindElement(By.XPath("(//a[@title='Summer Dresses'][normalize-space()='Summer Dresses'])[2]"));

        public void ClickSignin()
        {
            buttonSignin.Click();
        }
        
        public void HoverOnMenuDresses()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(menuDresses).Perform();
        }

        public void ClickMenuItemSummerDresses()
        {
            menuItemSummerDresses.Click();
        }
    }
}
