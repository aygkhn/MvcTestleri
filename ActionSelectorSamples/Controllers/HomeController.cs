using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectorSamples.Controllers
{
    public class AjaxMethodAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.IsAjaxRequest();
        }
    }

    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("IndexDemo")]
        public ViewResult Index()
        {
            return View();
        }

        [NonAction]
        public string GetConnectionString()
        {
            return "my connection string";
        }

        public void Test()
        {
            //I am an action;
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        //[HttpGet]
        //[HttpPost]
        //[AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        [AcceptVerbs("Post","Get","Put")]
        public ActionResult Something()
        {
            return Content("message from action");
        }
    }
}