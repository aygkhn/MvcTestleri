using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //return View("About","_Layout");

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}