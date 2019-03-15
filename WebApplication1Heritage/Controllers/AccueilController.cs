using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1Heritage.Models;


namespace WebApplication1Heritage.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Accueil()
        {
            var acc = new Accueil()
            {
                Name = "Ismaila"
            };
            return View(acc);
        }
    }
}