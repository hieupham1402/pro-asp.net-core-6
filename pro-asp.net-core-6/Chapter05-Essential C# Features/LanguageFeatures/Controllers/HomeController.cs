using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //object[] data = new object[] { 275M, 29.95M,
            //"apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}
            //return View("Index", new string[] { $"Total: {total:C2}" });
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M}
            };
                decimal cartTotal = cart.TotalPrices();
                decimal arrayTotal = productArray.TotalPrices();
            return View("Index", new string[] {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}" });

        }
    }
}