using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace CustomFilterSample.Filters
{
    public class CustomFilter :FilterAttribute, IAuthenticationFilter, IAuthorizationFilter, IActionFilter, IResultFilter, IExceptionFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            Debug.WriteLine("OnAuthentication");
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            Debug.WriteLine("OnAuthenticationChallenge");
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Debug.WriteLine("OnAuthorization");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("OnResultExecuting");
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("OnResultExecuted");
        }

        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is DivideByZeroException)
            {
                filterContext.Result= new ViewResult()
                {
                    ViewName = "DivideByZero"
                };
            }

            Debug.WriteLine("OnException");
        }
    }

    public class CustomFilter2 :ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }
    }
}