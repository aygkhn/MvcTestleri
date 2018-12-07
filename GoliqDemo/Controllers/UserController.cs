using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using GoliqDemo.Models;

namespace GoliqDemo.Controllers
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
        public ActionResult Insert(User user)
        {
            Thread.Sleep(1000);

            user.Id = Guid.NewGuid();

            Users.Add(user);

            return PartialView("List",Users);
        }

        public ActionResult Delete(Guid userId)
        {
            Thread.Sleep(1000);

            var user = Users.Single(t => t.Id == userId);
            Users.Remove(user);

            return PartialView("List", Users);
        }
    }
}