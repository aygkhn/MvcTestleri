using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDemo.Models.DataAccess;
using NorthwindDemo.Models.Entities;
using NorthwindDemo.Models.ProductModels;
using NorthwindDemo.Selectors;

namespace NorthwindDemo.Controllers
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
                    Products = context.Products.Include("Category").OrderByDescending(t => t.ProductId).ToList()
                };

                return View(model);
            }
        }

        public ActionResult Insert_HtmlElements()
        {
            return View();
        }


        public ActionResult Insert_HtmlHelpers()
        {
            using (var context = new NorthwindContext())
            {
                ViewBag.Categories = context.Categories.ToList();

                return View();
            }
        }

        public ActionResult Insert_ForModel()
        {
            using (var context = new NorthwindContext())
            {
                var model = new ProductInsertViewModel
                {
                    Product = new Product(),
                    Categories = context.Categories.ToList()
                };

                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Insert(Product product, HttpPostedFileBase file)
        {
            //if (string.IsNullOrEmpty(product.ProductName))
            //{
            //    ModelState.AddModelError("", "ProductName is required");
            //}

            //if (product.CategoryId == 0)
            //{
            //    ModelState.AddModelError("", "Category is required");
            //}

            //var categoryName = product.Category.CategoryName;
            using (var context = new NorthwindContext())
            {
                if (!ModelState.IsValid)
                {
                    //ViewBag.Categories = context.Categories.ToList();

                    //return View("Insert_HtmlHelpers");

                    var model = new ProductInsertViewModel
                    {
                        Product = product,
                        Categories = context.Categories.ToList()
                    };

                    return View("Insert_ForModel", model);
                }

                #region File Upload

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/files"), fileName);

                    file.SaveAs(path);
                }

                #endregion

                context.Products.Add(product);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [MultipleAction]
        public ActionResult Delete(List<int> ids)
        {
            using (var context = new NorthwindContext())
            {
                foreach (var id in ids)
                {
                    var product = context.Products.Find(id);
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [MultipleAction]
        public ActionResult Export(List<int> ids)
        {
            List<Product> products;

            using (var context = new NorthwindContext())
            {
                products = context.Products
                    .Where(t => ids.Contains(t.ProductId))
                    .ToList();
            }

            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}