using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Microsoft.Security.Application;
using SecurityDemo.Models;

namespace SecurityDemo.Controllers
{
    public class UserController : Controller
    {
        private static List<User> Users;

        static UserController()
        {
            Users= new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FullName = "Salih Demiroğ",
                    Mail = "salih@goliq.net",
                    UserName = "salihdemirog",
                    About = "http://goliq.net/"
                }
            };
        }

        public ActionResult List()
        {
            return PartialView(Users);
        }

        public ActionResult Insert()
        {
            var model = new UserIndexViewModel
            {
                User= new User()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Insert(User user)
        {
            user.Id = Guid.NewGuid();

            user.About = Sanitizer.GetSafeHtmlFragment(user.About);

            Users.Add(user);

            return RedirectToAction("Insert");
        }

        public ActionResult Delete(Guid userId)
        {
            var user = Users.Single(t => t.Id == userId);
            Users.Remove(user);

            return RedirectToAction("Insert");
        }
    }
}