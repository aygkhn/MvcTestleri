using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ContentResult Index()
        {
           //return Content("Salih Demiroğ");
            //return Content("Salih Demiroğ", "text/html; charset=utf-8");
            return Content("Salih Demiroğ", "text/html", Encoding.UTF8);
        }

        public ContentResult Index2()
        {
            //return Content("<b>Salih Demiroğ</b>");
            return Content("<b>Salih Demiroğ</b>", "text/plain");
        }

        public ContentResult Index3()
        {
            var xml = "<products>" +
                      "<product><name>Laptop</name></product>" +
                      "<product><name>Mouse</name></product>" +
                      "</products>";

            return Content(xml, "application/xml");
        }
    }
}