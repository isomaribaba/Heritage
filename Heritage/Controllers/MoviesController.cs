using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Heritage.Models;

namespace Heritage.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Bonjour" };
            return View(movie);
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/" + month);
        }
    }
}