using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DisplayAndEditorTemplate
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public override void Init()
        {
            PostAcquireRequestState += MvcApplication_PostAcquireRequestState;

            base.Init();
        }

        void MvcApplication_PostAcquireRequestState(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
