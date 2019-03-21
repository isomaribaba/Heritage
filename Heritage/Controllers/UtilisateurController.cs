using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Heritage.Models;

namespace Heritage.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: Utilisateur
        [HttpGet]
        public ActionResult utilisateurId(string UtilisateurId)
        {
            bool Status = false;
            using (HeritageEntities dc = new HeritageEntities())
            {
                dc.Configuration.ValidateOnSaveEnabled = false;
            }
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult utilisateur(Utilisateur utilisateur)
        {

            return View(utilisateur);
        }
    }
}