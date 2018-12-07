using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using DependencyInjection.Models.Loggers;
using Ninject;

namespace DependencyInjection.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel= new StandardKernel();

            _kernel.Bind<ILogger>().To<FileLogger>();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            //return base.GetControllerInstance(requestContext, controllerType);

            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}