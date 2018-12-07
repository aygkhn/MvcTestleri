using System.Diagnostics;
using System.Web.Mvc;

namespace CustomFilterSample.Filters
{
    public class AuthorizationFilterB : FilterAttribute, IAuthorizationFilter
    {
        private readonly string _scope;

        public AuthorizationFilterB(string scope)
        {
            _scope = scope;
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Debug.WriteLine("Action:{0} Filter:{1} Scope:{2}", filterContext.ActionDescriptor.ActionName, "AuthorizationFilterB", _scope);
        }
    }
}