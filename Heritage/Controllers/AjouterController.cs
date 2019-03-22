using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Heritage.Controllers
{
    public class AjouterController : Controller
    {
        // GET: Ajouter
        public ActionResult AjouterForm()
        {
            return View();
        }
    }
}