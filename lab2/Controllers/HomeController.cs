using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string login, string pass)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(pass))
                using (CourseDbEntities db = new CourseDbEntities())
                {
                    var p = db.People.Where(x => x.Login == login && x.Password == pass).FirstOrDefault();

                    if (p != null)
                    {
                        //If teacher
                        if (p.isTeacher)
                        {
                            int courseId = db.Courses.Where(x=>x.PersonId == p.PersonId).Select(x=>x.CourseId).FirstOrDefault();
                            RedirectToAction("Index", "TeacherController", courseId); // TODO: TeacherController/Index
                        }
                        //If student
                        else
                            RedirectToAction("Index", "StudentController", p.PersonId); // TODO: StudentController/Index
                    }

                }

            return View();
        }
    }
}