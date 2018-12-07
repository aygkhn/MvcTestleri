using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class AccountController : Controller
    {
        public static List<User> Users { get; set; }

        static AccountController()
        {
            Users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "engin",
                    FullName = "Engin Demiroğ",
                    Mail = "engin@goliq.com",
                    Password = "123456"
                }
            };
        }

        [Route("register")]
        public ActionResult Register()
        {
            var model = new User();

            return View(model);
        }

        [Route("register")]
        [HttpPost]
        public ActionResult Register(User user)
        {
            user.Id = Guid.NewGuid();
            Users.Add(user);

            //return RedirectToRoute("Profile", new { userName = user.UserName });
            return RedirectToAction("Profile", new { userName = user.UserName });
        }

        [Route("u/{userName:alpha}")]
        public ActionResult Profile(string userName)
        {
            var student = Users.FirstOrDefault(t => t.UserName == userName);

            if (student == null) return new HttpNotFoundResult();

            return View(student);
        }
    }
}