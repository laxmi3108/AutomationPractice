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
    class MyAccount : Selenium_Base
    {
        Women womens=new Women();
        public void GoToMyAcc(IWebDriver Driver)
        {
            womens.GoToAutomation(Driver);
        }
        public void OrderHistory(IWebDriver Driver)
        {
            scrollPage(0, 300);
            wait(1000);

            click(FindXPath("//span[text()='Order history and details']"));
            wait(1000);

            scrollPage(0, 600);
            wait(1000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?controller=my-account']//i"));
            wait(1000);

            click(FindXPath("//span[text()='My wishlists']"));
            wait(1000);

            scrollPage(0, 500);
            wait(1000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?controller=my-account']//i"));
            wait(1000);

            click(FindXPath("//span[text()='My credit slips']"));
            wait(1000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?controller=my-account']//i"));
            wait(1000);

            click(FindXPath("//span[text()='My addresses']"));
            wait(1000);

            scrollPage(0, 500);
            wait(1000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?controller=my-account']//i"));
            wait(1000);

            click(FindXPath("//span[text()='My personal information']"));
            wait(1000);

            scrollPage(0, 800);
            wait(1000);

            click(FindXPath("//a[@href='http://automationpractice.com/index.php?controller=my-account']//i"));
            wait(1000);
        }
        public void Sign_out(IWebDriver Driver)
        {
            click(FindXPath("//a[@class='logout']"));
            wait(2000);
        }
    }
}
