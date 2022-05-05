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
    class AddToWishList : Selenium_Base
    {
        public void AddtoWishlist(IWebDriver Driver)
        {
            open("http://automationpractice.com/index.php");
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Women']"));
            wait(1000);

            click(FindXPath("//ul[@style='display: none;']//a[@title='T-shirts']"));
            wait(2000);

            scrollPage(0, 700);
            wait(2000);

            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/1-home_default.jpg']"));
            wait(2000);

            click(FindXPath("//a[@class='addToWishlist wishlistProd_1']"));
            wait(5000);

            click(FindXPath("//a[@title='Close']"));
            wait(3000);

            close();
        }
    }
}
