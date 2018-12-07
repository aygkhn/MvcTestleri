using System.Web.Mvc;

namespace Routing.Controllers
{
    //[RoutePrefix("Main")]
    [Route("{action=Index}")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[Route("~/about")]
        public ActionResult About()
        {
            return View();
        }

        //[Route("contact-us")]
        public ActionResult Contact()
        {
            return View();
        }

        //[Route("~/demo/{number=1}/{id?}")]
        //public ActionResult Demo(int number,int? id)
        //{
        //    return Content(string.Format("Number={0} <br/> Id={1}", number, id.HasValue ? id.ToString() : "null"));
        //}
    }
}