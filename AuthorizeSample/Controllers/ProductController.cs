using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizeSample.Controllers
{
    [Authorize]
    public class ProductController : Controller
    { 
        [AllowAnonymous]
        public ActionResult List()
        {
            return View();
        }

        [Authorize(Users = "salih,engin")]
        public ActionResult Insert()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Boss")]
        public ActionResult Update()
        {
            return View();
        }
    }
}