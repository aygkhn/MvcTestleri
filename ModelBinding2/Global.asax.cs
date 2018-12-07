using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ModelBinding2.ModelBinders;
using ModelBinding2.Models;

namespace ModelBinding2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            System.Web.Mvc.ModelBinders.Binders.Add(typeof (UserComplex), new UserComplexModelBinder());
        }
    }
}
