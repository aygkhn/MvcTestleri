using System.Web.Mvc;
using System.Web.Routing;
using FluentValidation.Mvc;
using NorthwindDemo.ModelBinders;

namespace NorthwindDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;

            ModelValidatorProviders.Providers.Clear();

            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider
            {
                AddImplicitRequiredValidator = false
            });

            System.Web.Mvc.ModelBinders.Binders.DefaultBinder = new CustomDefaultModelBinder();
        }
    }
}
