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

            ////Test Case
            Sign_in sign_In = new Sign_in();

            sign_In.CreateAc(Driver);

            VerifyError verifyError = new VerifyError();

            verifyError.InvalidEmail(Driver);

            verifyError.MandatoryFields(Driver);

            verifyError.InvalidValue(Driver);

            Search search = new Search();

            search.SearchProduct(Driver);

            Buy buy = new Buy();

            buy.BuyProduct(Driver);

            AddToWishList addToWishList = new AddToWishList();

            addToWishList.AddtoWishlist(Driver);

            PriceChanging priceChanging = new PriceChanging();

            priceChanging.PriceReflecting(Driver);

            ////Test Case End

            Women women = new Women();

            women.GoToAutomation(Driver);
            women.GoToWomen(Driver);
            women.WomenCatalog(Driver);
            women.HoverToItem(Driver);
            women.More(Driver);
            women.QuickView(Driver);
            women.color(Driver);
            women.HoverAndAddToCart(Driver);
            women.feature(Driver);
            women.Range(Driver);
            women.Information(Driver);
            women.ShortBy(Driver);
            women.List(Driver);
            women.AddToWishList(Driver);
            women.AddToCompare(Driver);
            women.Cart(Driver);
            women.EmptyCart(Driver);
            women.Search(Driver);
            women.SubCategories(Driver);

            MyAccount myAccount = new MyAccount();

            myAccount.GoToMyAcc(Driver);
            myAccount.OrderHistory(Driver);
            myAccount.Sign_out(Driver);


        }
    }
}
