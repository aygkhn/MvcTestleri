using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding2.ModelBinders;
using ModelBinding2.Models;
using ModelBinding2.Models.UserModels;

namespace ModelBinding2.Controllers
{
    public class UserController : Controller
    {
        // GET: Person
        public ViewResult Index()
        {
            using (var context = new GoliqContext())
            {
                var model = new UserIndexViewModel
                {
                    Users = context.Users.ToList()
                };

                return View(model);
            }
        }

        [HttpGet]
        public ViewResult Insert()
        {
            return View();
        }

        #region Using Request Object
        /*
        [HttpPost]
        public RedirectToRouteResult UserInsert()
        {
            var firstName = Request.Form["firstName"];
            var lastName = Request.Form["lastName"];
            var birthDate = Convert.ToDateTime(Request.Form["birthDate"]);

            using (var context = new GoliqContext())
            {
                context.Users.Add(new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate
                });

                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        */
        #endregion

        #region Using Primitive Types
       
        /*
        [HttpPost]
        public RedirectToRouteResult UserInsert(string firstName, string lastName, DateTime birthDate)
        {
            using (var context = new GoliqContext())
            {
                context.Users.Add(new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate
                });

                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        */

        #endregion

        #region Using FormCollection
        
        /*
        [HttpPost]
        public RedirectToRouteResult UserInsert(FormCollection collection)
        {
            var firstName = collection["firstName"];
            var lastName = collection["lastName"];
            var birthDate = Convert.ToDateTime(collection["birthDate"]);

            using (var context = new GoliqContext())
            {
                context.Users.Add(new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate
                });

                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        */

        #endregion

        #region Using ComplexType
        
        //[HttpPost]
        //public RedirectToRouteResult UserInsert(User user)
        //{
        //    using (var context = new GoliqContext())
        //    {
        //        context.Users.Add(user);
        //        context.SaveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}

        #endregion

        #region Using Custom ModelBinder

        [HttpPost]
        public EmptyResult UserInsert(UserComplex userComplex)
        {
            return new EmptyResult();
        }

        #endregion
    }
}