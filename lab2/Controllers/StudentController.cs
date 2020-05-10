using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index(int id)
        {

            return View();
        }
    }
}