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
    class Search : Selenium_Base
    {
        public void SearchProduct(IWebDriver Driver)
        {
            open("http://automationpractice.com/index.php");
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Women']"));
            wait(1000);

            click(FindXPath("//ul[@style='display: none;']//a[@title='T-shirts']"));
            wait(2000);

            scrollPage(0, 400);
            wait(2000);

            scrollPage(0, -400);
            wait(2000);

            sendKeys(FindXPath("//input[@id='search_query_top']"), "Faded Short Sleeve T-shirts");
            wait(2000);

            click(FindXPath("//button[@name='submit_search']"));
            wait(2000);

            scrollPage(0, 400);
            wait(4000);

            close();

        }
    }
}
