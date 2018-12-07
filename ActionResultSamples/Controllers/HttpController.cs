using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class HttpController : Controller
    {
        // GET: Http
        public HttpStatusCodeResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway);

            //return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "Bad Gateway From Mvc");

            //return new HttpStatusCodeResult(502);
        }

        public HttpUnauthorizedResult Index2()
        {
            //return new HttpUnauthorizedResult();

            return new HttpUnauthorizedResult("Not Authenticate");
        }

        public HttpNotFoundResult Index3()
        {
            //return HttpNotFound();

            return HttpNotFound("Sorry! This page not found");

            //return new HttpNotFoundResult();
        }
    }
}