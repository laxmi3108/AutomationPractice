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
    class Buy : Selenium_Base
    {
        public void Login(IWebDriver Driver)
        {
            click(FindXPath("//a[@class='login']"));
            wait(7000);

            scrollPage(0, 300);
            wait(2000);

            sendKeys(FindXPath("//input[@id='email']"), "gorailaxmi2001@gmail.com");
            wait(3000);

            sendKeys(FindXPath("//input[@id='passwd']"), "Laxmi@31");
            wait(2000);

            click(FindXPath("//button[@id='SubmitLogin']"));
            wait(5000);
        }
        public void BuyProduct(IWebDriver Driver)
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

            click(FindXPath("//a[@class='btn btn-default button-plus product_quantity_up']"));
            wait(2000);

            click(FindXPath("//div[@class='selector']"));
            wait(2000);

            click(FindXPath("//option[text()='L']"));
            wait(2000);

            click(FindXPath("//a[@id='color_14']"));
            wait(2000);

            click(FindXPath("//span[text()='Add to cart']"));
            wait(5000);

            click(FindXPath("//a[@title='Proceed to checkout']"));
            wait(2000);

            scrollPage(0, 700);
            wait(2000);

            click(FindXPath("//a[@title='Proceed to checkout']//span[text()='Proceed to checkout']"));
            wait(2000);

            scrollPage(0, 600);
            wait(2000);

            sendKeys(FindXPath("//textarea[@name='message']"), "Do it As soon as possible");
            wait(3000);

            click(FindXPath("//button[@name='processAddress']"));
            wait(2000);

            scrollPage(0, 300);
            wait(2000);

            click(FindXPath("//div[@id='uniform-cgv']"));
            wait(2000);

            click(FindXPath("//button[@name='processCarrier']"));
            wait(2000);

            scrollPage(0, 500);
            wait(2000);

            click(FindXPath("//a[@class='cheque']"));
            wait(2000);

            scrollPage(0, 200);
            wait(2000);

            click(FindXPath("//span[text()='I confirm my order']"));
            wait(2000);

            scrollPage(0, 200);
            wait(2000);

            close();
        }
    }
}
