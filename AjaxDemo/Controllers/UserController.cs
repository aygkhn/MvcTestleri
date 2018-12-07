using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
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
                    FullName = "Engin Demiroğ",
                    Mail = "engin@goliq.net",
                    UserName = "engindemirog"
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
        public ActionResult Insert(User user)
        {
            Thread.Sleep(2000);

            user.Id = Guid.NewGuid();
            Users.Add(user);

            return RedirectToAction("List");
        }

        public void Delete(Guid userId)
        {
            Thread.Sleep(2000);

            var user = Users.Single(t => t.Id == userId);
            Users.Remove(user);

            //return PartialView("List", Users);
            //return RedirectToAction("Insert");
        }
    }
}