using Heritage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Heritage.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactFrom(ContactModel model)
        {
             if(ModelState.IsValid)
            { 
                   insertContact(model.name, model.prenom, model.email, model.commentaire);
                   return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void insertContact(string name, string prenom, string email, string commentaire)
        {
            //throw new NotImplementedException();
        }
    }
}