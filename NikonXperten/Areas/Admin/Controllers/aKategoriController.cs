using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNX;

namespace NikonXperten.Areas.Admin.Controllers
{
    public class aKategoriController : Controller
    {
        KategoriFac kf = new KategoriFac();

        // GET: Admin/aKategori
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult AddKat(Kategori kat)
        {
            if (ModelState.IsValid)
            {
                kf.Insert(kat);
                ViewBag.MSG = "Din Kategori er blevet oprettet";
            }
            else
            {
                ViewBag.MSG = "Du skal udfylde alle felter";
            }


            return View("Index");
        }

        [Authorize]
        public ActionResult Edit()
        {
            return View(kf.GetAll());
        }

        [Authorize]
        public ActionResult EditForm(int id)
        {
            return View(kf.Get(id));
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditResult(Kategori kat)
        {
            if (ModelState.IsValid)
            {
                kf.Update(kat);
            }

            return RedirectToAction("Edit");
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            kf.Delete(id);
            return RedirectToAction("Edit");
        }
    }
}