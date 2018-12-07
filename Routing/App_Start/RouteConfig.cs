using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            #region RouteSamples

            //routes.Add(new Route("{resource}.axd/{*pathInfo}", new StopRoutingHandler()));
            //routes.IgnoreRoute("{controller}/Index");

            //routes.MapRoute(
            //    name: "About",
            //    url: "about",
            //    defaults: new { controller = "Home", action = "About" }
            //    );

            //routes.Add("About",
            //    new Route("about", new RouteValueDictionary(new {controller = "Home", action = "About"}),
            //        new MvcRouteHandler()));

            //routes.MapRoute(
            //    name: "Contact",
            //    url: "contact-us",
            //    defaults: new { controller = "Home", action = "Contact" },
            //    constraints: new { httpMethod = new HttpMethodConstraint("POST","GET")}
            //    );

            //routes.MapRoute(
            //    name: "Register",
            //    url: "register",
            //    defaults: new { controller = "Account", action = "Register" }
            //    );

            //routes.MapRoute(
            //   name: "Profile",
            //   url: "u/{userName}",
            //   defaults: new { controller = "Account", action = "Profile" }
            //   );

            //routes.MapRoute(
            //   name: "Demo",
            //   url: "{controller}-{action}/{id}",
            //   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //   );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new { controller = "^H.*", action = "Index|About" }
            //    );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new { id = @"\d+" }
            //    );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new { id = new OnlyDigitConstraint() }
            //    );

            #endregion
        }

        private class OnlyDigitConstraint : IRouteConstraint
        {
            public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values,
                RouteDirection routeDirection)
            {
                if (routeDirection != RouteDirection.IncomingRequest) return false;

                if (values[parameterName] == UrlParameter.Optional)
                    return true;

                int id;
                return Int32.TryParse(values[parameterName].ToString(), out id);
            }
        }
    }
}
