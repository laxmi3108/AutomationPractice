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
    class PriceChanging : Buy
    {
        public void PriceReflecting(IWebDriver Driver)
        {
            open("http://automationpractice.com/index.php");
            wait(500);

            Login(Driver);
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Women']"));
            wait(1000);

            click(FindXPath("//ul[@style='display: none;']//a[@title='T-shirts']"));
            wait(2000);

            scrollPage(0, 700);
            wait(2000);

            hoverOnto(FindXPath("//img[@src='http://automationpractice.com/img/p/1/1-home_default.jpg']"));
            wait(2000);

            click(FindXPath("//span[text()='More']"));
            wait(5000);

            scrollPage(0, 300);
            wait(3000);

            click(FindXPath("//div[@class='selector']"));
            wait(2000);

            click(FindXPath("//option[text()='M']"));
            wait(2000);

            click(FindXPath("//a[@id='color_14']"));
            wait(2000);

            click(FindXPath("//span[text()='Add to cart']"));
            wait(5000);

            click(FindXPath("//a[@title='Proceed to checkout']"));
            wait(2000);

            scrollPage(0, 500);
            wait(3000);

            click(FindXPath("//i[@class='icon-plus']"));
            wait(5000);

            close();
        }
    }
}
