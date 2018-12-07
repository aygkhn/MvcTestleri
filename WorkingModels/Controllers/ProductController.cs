using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WorkingModels.Models;
using WorkingModels.Models.ProductModels;

namespace WorkingModels.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            using (var context = new NorthwindContext())
            {
                var model = new ProductIndexViewModel
                {
                    Products = context.Products.ToList(),
                    Categories = context.Categories.ToList()
                };

                return View("Index2",model);
            }
        }

        public ActionResult Demo()
        {
            return View(model: "Salih");
        }
    }
}