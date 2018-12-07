using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AuthorizeSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_PostAuthenticateRequest()
        {
            if (User.Identity.IsAuthenticated)
            {
                var name = User.Identity.Name;

                if (name == "salih")
                {
                    var roles = new string[] { "Developer" };
                    HttpContext.Current.User =
                        Thread.CurrentPrincipal =
                        new GenericPrincipal(User.Identity, roles);

                }
            }
        }
    }
}
