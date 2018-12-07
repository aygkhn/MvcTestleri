using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var categoryId = RouteData.Values["categoryId"];
            var name = RouteData.Values["name"];

            var lastName = Request.QueryString["lastName"];
            var productId = Request.QueryString["productId"];

            //return RedirectToAction("Index2",
            //    new {controller = "Home", categoryId = 14, name = "engin", fullName = "salih demirog"});
            return Content(string.Format("Controller:{0} - Action:{1}", controller, action));
        }

        public ActionResult Index2(string controller, string action, int id)
        {
            return new EmptyResult();
        }
    }
}