using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Net;
using System.Collections.ObjectModel;
using DemoQASite;

namespace AutomationPractice
{
    internal class Program : Selenium_Base
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = null;

            Women women = new Women();

            women.GoToAutomation(Driver);

            women.GoToWomen(Driver);

            women.WomenCatalog(Driver);

            women.HoverToItem(Driver);

            women.More(Driver);

            women.QuickView(Driver);

            women.color(Driver);

            women.AddToCart(Driver);

            women.feature(Driver);

            women.Range(Driver);

            women.Information(Driver);

            women.ShortBy(Driver);

            women.List(Driver);

            women.AddToWishList(Driver);

            women.AddToCompare(Driver);

            women.Cart(Driver);

            women.Search(Driver);

            women.SubCategories(Driver);
        }
    }
}
