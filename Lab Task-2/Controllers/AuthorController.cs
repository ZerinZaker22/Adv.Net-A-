using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Introduction(Author a)
        {
            a.Name = "Humayun Ahmed";
            a.About = "Bangladeshi novelist";
            a.DOB = "13 November 1948";
            a.Awards = new string[]
            { 
              "Best Dialogue. Anil Bagchir Ekdin (2015)",
              "Best Director. Ghetuputra Komola (2012)",
              "Best Screenplay. Ghetuputra Komola (2012)"
            };
            return View(a);
        }

        public ActionResult Books(Author a)
        {
            a.Books = new string[] { "Opekkha", "Himu", "Misir Ali" };
            return View(a);
        }
    }
}