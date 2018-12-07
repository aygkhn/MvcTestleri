using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.Models.Loggers;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(ILogger logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            //var logger = new DatabaseLogger();
            //logger.Log();

            _logger.Log();

            return Content("DenemeDeğişiklik2");
        }
    }
}