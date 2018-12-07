using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingDataFromControllersToView.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        public ActionResult Index()
        {
            ViewData["Title"] = "Ilk Mvc Projesi";
            ViewBag.Title = "Ilk Mvc Projesi";
            ViewBag.Numbers = new int[] {1,2,3,4,5 };
            TempData["message"] = "Message from TempData";
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            return View();
        }
    }
}