using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace NorthwindDemo.Controllers
{
    public class AccountController : Controller
    {
        [ChildActionOnly]
        public ActionResult Login()
        {
            var model = "Salih Demiroğ";

            //return PartialView("_Login", model);
            return Content(string.Format("<b>Welcome</b> {0}", model));
        }
    }
}