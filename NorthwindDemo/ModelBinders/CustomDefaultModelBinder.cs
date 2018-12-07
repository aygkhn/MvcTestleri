using System.ComponentModel;
using System.Web.Mvc;

namespace NorthwindDemo.ModelBinders
{
    public class CustomDefaultModelBinder : DefaultModelBinder
    {
        protected override void OnPropertyValidated(ControllerContext controllerContext, ModelBindingContext bindingContext,
            PropertyDescriptor propertyDescriptor, object value)
        {
            bindingContext.ModelState.Clear();
        }
    }
}