using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingDataFromControllersToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["message"] = "Message from ViewData";

            ViewBag.MessageV = "Message from ViewBag";

            ViewBag.Numbers = new[] {1, 2, 3, 4};

            TempData["message"] = "Message from TempData";

            return RedirectToAction("Index2");
            //return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}