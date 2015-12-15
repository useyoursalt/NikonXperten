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
        // GET: Admin/aKategori
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult Edit()
        {
            return View(kf.GetAll());
        }

        public ActionResult EditForm(int id)
        {
            return View(kf.Get(id));
        }

        [HttpPost]
        public ActionResult EditResult(Kategori kat)
        {
            if (ModelState.IsValid)
            {
                kf.Update(kat);
            }

            return RedirectToAction("Edit");
        }


        public ActionResult Delete(int id)
        {
            kf.Delete(id);
            return RedirectToAction("Edit");
        }
    }
}