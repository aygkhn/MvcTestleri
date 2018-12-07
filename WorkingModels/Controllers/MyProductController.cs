using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingModels.Models;
using WorkingModels.Models.MyProductModels;

namespace WorkingModels.Controllers
{
    public class MyProductController : Controller
    {
        // GET: MyPrudoct
        public ActionResult Index()
        {
            using (var context = new NorthwindContext())
            {
                List<Product> product = context.Products.ToList();
                List<Category> category = context.Categories.ToList();
                var model = new MyProductIndexViewModel {
                    Categories = category,
                    Products = product
                };
                return View(model);
            }

        }
        public ActionResult Demo()
        {
            return View(model: "Salih");
        }
    }
}