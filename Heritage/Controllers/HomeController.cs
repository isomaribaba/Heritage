using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Heritage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description des écoles.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Les Champs avec * sont obligatoires";

            return View();
        }
    }
}