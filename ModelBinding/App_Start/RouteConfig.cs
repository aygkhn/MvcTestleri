using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ModelBinding
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{categoryId}/{name}",
                defaults: new { controller = "Home", action = "Index", categoryId = UrlParameter.Optional, name = UrlParameter.Optional }
            );
        }
    }
}
