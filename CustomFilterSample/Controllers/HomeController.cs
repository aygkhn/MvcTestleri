using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomFilterSample.Filters;

namespace CustomFilterSample.Controllers
{
    [AuthorizationFilterB("Controller",Order = 2)]
    [AuthorizationFilterA("Action", Order = 1)]
    public class HomeController : Controller
    {
        public ActionResult Demo()
        {
            Debug.WriteLine("Hello World");

            return View();
        }
    }
}