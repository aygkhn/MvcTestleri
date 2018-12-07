using System;
using System.Web.Mvc;

namespace HandleErrorSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Error From Home Index");
            return View();
        }
    }
}