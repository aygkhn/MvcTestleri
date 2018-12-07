using System;
using System.Web.Mvc;
using System.Web.UI;

namespace OutputCacheSample.Controllers
{
    //[OutputCache(Duration = 10)]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult GetTime()
        {
            return Content(string.Format("Time: {0}", DateTime.Now.ToString("T")));
        }

        [OutputCache(Duration = 10, Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult GetUserName()
        {
            return Content(string.Format("Name: {0}", User.Identity.Name.Substring(User.Identity.Name.IndexOf("\\") + 1)));
        }

        [OutputCache(Duration = 360, VaryByParam = "none")]
        public ActionResult Detail(int id, string name)
        {
            return Content(string.Format("Time:{0} , Id: {1} , Name={2}", DateTime.Now.ToString("T"), id, name));
        }

        [OutputCache(CacheProfile = "Cache1Hour")]
        public string GetProfile()
        {
            return DateTime.Now.ToString("T");
        }
    }
}