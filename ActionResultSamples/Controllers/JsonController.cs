using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class Product
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }
    }

    public class JsonController : Controller
    {
        // GET: Json
        public JsonResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Laptop",
                    UnitPrice = 700,
                },
                new Product
                {
                    Name = "Mouse",
                    UnitPrice = 5
                }
            };

            return Json(products, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
    }
}