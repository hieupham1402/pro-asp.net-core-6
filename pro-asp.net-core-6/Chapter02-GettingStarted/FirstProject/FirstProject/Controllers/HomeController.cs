using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        #region MyView.cshtml
        //public string Index()
        // {
        //     //Print Hello world when run app
        //     return "Hello World";
        // }

        //find MyView in Views/Home/MyView.cshtml
        //public ViewResult Index()
        //{
        //    return View("MyView");
        //}
        #endregion

        #region Adding Dynamic Output
        // ViewResult:đại diện cho một trang HTML được hiển thị cho người dùng thông qua một view.
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }

        #endregion
    }
}