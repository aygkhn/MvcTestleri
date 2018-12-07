using System.IO;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public FileResult Index()
        {
            //return File("~/Content/goliq.doc", "application/msword");

            //return File("~/Content/goliq.doc", "application/msword", "goliq.doc");

            //return File("~/Content/goliq.txt", "text/plain");

            //return File("~/Content/goliq.txt", "text/plain", "goliq.txt");

            return new FilePathResult("~/Content/goliq.txt", "text/plain")
            {
                FileDownloadName = "goliq.txt"
            };
        }

        public FileContentResult Index2()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/goliq.txt"));

            return File(bytes, "text/plain", "goliq.txt");
        }

        public ActionResult Index3()
        {
            var fileStream = new FileStream(Server.MapPath("~/Content/goliq.txt"), FileMode.Open);

            return File(fileStream, "goliq.txt");
        }
    }
}