using System;
using System.Web.Mvc;

namespace HandleErrorSample.Controllers
{
    //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZero")]
    public class ProductController : Controller
    {
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Insert()
        {
            var i = 0;
            var d = 200 / i;

            return View();
        }

        public ActionResult Update()
        {
            throw new NotImplementedException("Error from Update");

            return View();
        }
    }
}