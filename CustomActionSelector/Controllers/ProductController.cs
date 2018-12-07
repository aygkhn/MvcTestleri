using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace CustomActionSelector.Controllers
{
    public class Product
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
    }

    public class AjaxMethodAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.IsAjaxRequest();
        }
    }

    public class ActionLengthAttribute : ActionNameSelectorAttribute
    {
        private readonly int _length;

        public ActionLengthAttribute(int length)
        {
            _length = length;
        }

        public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
        {
            return actionName.Length <= _length;
        }
    } 

    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [ActionLength(5)]
        //[ActionName("Index")]
        public ActionResult Test()
        {
            return Content("test");
        }

        [AjaxMethod,ActionLength(10)]
        public JsonResult GetAll()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductName = "Laptop",
                    UnitPrice = 700
                },
                new Product
                {
                    ProductName = "Mouse",
                    UnitPrice = 10
                },
            };

            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}