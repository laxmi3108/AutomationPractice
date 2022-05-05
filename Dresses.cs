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
    class Dresses : Selenium_Base
    {
        Buy buy = new Buy();


        public void dress(IWebDriver Driver)
        {
            buy.Login(Driver);
            click(FindXPath(""));
        }
    }
}
