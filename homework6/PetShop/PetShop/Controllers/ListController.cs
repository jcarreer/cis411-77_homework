using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PetShop.Controllers
{
    public class ListController : Controller
    {
        private PetDBContext db = new PetDBContext();

      
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Pet pet = db.Pets.Find(id);

            if (pet == null)
            {
                return HttpNotFound();
            }

            return View(pet);
        }
    }
}