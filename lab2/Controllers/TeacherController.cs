using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace lab2.Controllers
{
    public class TeacherController : Controller
    {
        public async Task<ActionResult> Index(int courseId = 0)
        {
            TeacherView data = new TeacherView();
            if (courseId != 0)
            {
                using (CourseDbEntities db = new CourseDbEntities())
                {
                    //var all = db.TeacherViews.ToList();
                    data = db.TeacherViews.Where(x => x.CourseId == courseId).FirstOrDefault();
                }

                return View(data);
            }
            return View();
        }
    }
}