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
    class Sign_in : Selenium_Base
    {
        public void CreateAc(IWebDriver Driver)
        {
            open("http://automationpractice.com/index.php");
            wait(500);

            click(FindXPath("//a[@class='login']"));
            wait(10000);

            sendKeys(FindXPath("//input[@id='email_create']"), "laxmigorai123@gmail.com");
            wait(3000);

            click(FindXPath("//button[@id='SubmitCreate']"));
            wait(2000);

            scrollPage(0, 300);
            wait(7000);

            click(FindXPath("//input[@id='id_gender2']"));
            wait(5000);

            sendKeys(FindXPath("//input[@id='customer_firstname']"), "Laxmi");
            wait(2000);

            sendKeys(FindXPath("//input[@id='customer_lastname']"), "Gorai");
            wait(2000);

            sendKeys(FindXPath("//input[@id='passwd']"), "Laxmi@2001");
            wait(2000);

            scrollPage(0, 200);
            wait(1000);

            click(FindXPath("//div[@id='uniform-days']"));
            wait(2000);

            click(FindXPath("//select[@id='days']//option[@value='31']"));
            wait(2000);

            click(FindXPath("//div[@id='uniform-months']"));
            wait(2000);

            click(FindXPath("//select[@id='months']//option[@value='12']"));
            wait(2000);

            click(FindXPath("//div[@id='uniform-years']"));
            wait(2000);

            click(FindXPath("//select[@id='years']//option[@value='2001']"));
            wait(2000);

            click(FindXPath("//input[@id='newsletter']"));
            wait(2000);

            scrollPage(0, 400);
            wait(1000);

            sendKeys(FindXPath("//input[@id='company']"), "Testing");
            wait(2000);

            sendKeys(FindXPath("//input[@id='address1']"), "Shanti Nagar");
            wait(2000);

            sendKeys(FindXPath("//input[@id='address2']"), "Benachity");
            wait(2000);

            scrollPage(0, 300);
            wait(1000);

            sendKeys(FindXPath("//input[@id='city']"), "Durgapur");
            wait(2000);

            click(FindXPath("//select[@id='id_state']"));
            wait(2000);

            click(FindXPath("//option[text()='Colorado']"));
            wait(2000);

            sendKeys(FindXPath("//input[@id='postcode']"), "56240");
            wait(2000);

            click(FindXPath("//select[@id='id_country']"));
            wait(2000);

            click(FindXPath("//option[text()='United States']"));
            wait(2000);

            sendKeys(FindXPath("//textarea[@id='other']"), "NA");
            wait(2000);

            sendKeys(FindXPath("//input[@id='phone']"), "7432825194");
            wait(2000);

            sendKeys(FindXPath("//input[@id='phone_mobile']"), "9046773962");
            wait(2000);

            click(FindXPath("//button[@id='submitAccount']"));
            wait(4000);

            close();
        }
    }
}
