using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayAndEditorTemplate.Models;

namespace DisplayAndEditorTemplate.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> Students { get; set; }

        static StudentController()
        {
            Students = new List<Student>
            {
                new Student
                {
                    FullName = "Salih Demiroğ",
                    BirthDate = new DateTime(1986, 11, 10),
                    IsGraduate = true,
                    StudentId = 5
                },
                new Student
                {
                    FullName = "Engin Demiroğ",
                    BirthDate = new DateTime(1985, 1, 6),
                    IsGraduate = true,
                    StudentId = 20
                }
            };
        }

        public ActionResult Index()
        {
            var model = Students;

            return View(model);
        }

        public ActionResult Insert()
        {
            var model = new Student();

            return View(model);
        }

        [HttpPost]
        public ActionResult Insert(Student student)
        {
            Students.Add(student);

            return RedirectToAction("Index");
        }

        public ActionResult Detail(int? studentId)
        {
            if (!studentId.HasValue)
                return RedirectToAction("Index");

            var student = Students.FirstOrDefault(t => t.StudentId == studentId);

            return View(student);
        }
    }
}