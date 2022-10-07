using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Form.Models;

namespace Form.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: Course
        [HttpPost]
        public ActionResult Index(Course c)
        {
            
            if(ModelState.IsValid)
            {
                return RedirectToAction("About", "Home");
            }

            return View(c);
        }
    }
}