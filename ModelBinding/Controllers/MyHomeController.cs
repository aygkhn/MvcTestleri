using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        public ActionResult Index()
        {
            string controller= RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"];
            var id = RouteData.Values["categoryId"];
            return Content(string.Format("{0}/{1}/{2}",controller,action,id));
        }
    }
}