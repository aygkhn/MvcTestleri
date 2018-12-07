using System.Web.Mvc;
using System.Web.Security;
using AuthorizeSample.Models;

namespace AuthorizeSample.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return User.Identity.IsAuthenticated
                ? View("Unauthorized")
                : View("Login", new User());
        }

        [HttpPost]
        public ActionResult Login(User user, string returnUrl)
        {
            if (user.UserName == "salih" && user.Password == "1234")
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);

                return returnUrl == null ? RedirectToAction("Index", "Home") : (ActionResult)Redirect(returnUrl);
            }

            ViewBag.Warn = "The username or password is incorrect";

            return View(user);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}