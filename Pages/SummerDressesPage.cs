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
    public class SummerDressesPage : BasePage
    {
       List<string> itemsInSummerDresses = Driver.FindElements(By.CssSelector(".product-container .product-name"))
            .Select(item => item.Text.ToLower()).ToList();

        public int ItemsCount() => itemsInSummerDresses.Count;

        public List<string> ItemsNames() => itemsInSummerDresses;
    }
}