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
                        if (p.isTeacher)
                            return View(); // TODO: repair
                    }
                }

            return View();
        }
    }
}