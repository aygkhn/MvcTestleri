using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ActionResultSamples.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult Index2()
        {
            //return Redirect("~/view");

            return Redirect("http://microsoft.com");
        }

        public RedirectToRouteResult Index3()
        {
            //return RedirectToAction("Index");

            //return RedirectToAction("Index", "View");

            //return RedirectToAction("Index", new { controller = "View", id = 5 });

            //return RedirectToAction("Index", new RouteValueDictionary()
            //{
            //    { "controller", "View" }, 
            //    { "id", "6" }
            //});

            return RedirectToRoute("Default", new { controller = "View", action = "Index2" });
        }
    }
}