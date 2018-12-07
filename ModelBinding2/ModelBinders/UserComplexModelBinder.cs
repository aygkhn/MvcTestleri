using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding2.Models;

namespace ModelBinding2.ModelBinders
{
    public class UserComplexModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var firstName = controllerContext.HttpContext.Request.Form["firstName"];
            var lastName = controllerContext.HttpContext.Request.Form["lastName"];
            var birthDate =Convert.ToDateTime(controllerContext.HttpContext.Request.Form["birthDate"]);

            return new UserComplex
            {
                FullName = string.Format("{0} {1}", firstName, lastName),
                Age = (int) (DateTime.Now.Subtract(birthDate).TotalDays/365.0)
            };
        }
    }
}