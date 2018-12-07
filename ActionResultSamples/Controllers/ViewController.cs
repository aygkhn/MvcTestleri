using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            return View("Index");
        }

        public PartialViewResult Partial()
        {
            return PartialView();
        }

        public PartialViewResult Partial2()
        {
            return PartialView("Partial");
        }
    }
}