using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace TestProject1.Pages
{
    public class SearchPage : BasePage
    {
        IWebElement menuDresses => Driver.FindElement(By.XPath("(//a[@title='Dresses'][normalize-space()='Dresses'])[2]"));
        IWebElement menuItemSummerDresses = Driver.FindElement(By.XPath("(//a[@title='Summer Dresses'][normalize-space()='Summer Dresses'])[2]"));
        IList<string> itemsInSummerDresses = Driver.FindElements(By.CssSelector("product-container product-name")).Select(item => item.Text.ToLower()).ToList();

        public void HoverOnMenuDresses()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(menuDresses).Perform();
        }

        public void ClickMenuItemSummerDresses()
        {
            menuItemSummerDresses.Click();
        }
        public void CheckNamesToContainDress()
        {
            foreach (var item in itemsInSummerDresses)
            {
                Assert.That(item, Does.Contain("dress123"));
            }
        }
    }
}