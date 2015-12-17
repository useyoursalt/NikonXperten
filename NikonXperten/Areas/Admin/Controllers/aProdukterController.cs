using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNX;
using System.IO;

namespace NikonXperten.Areas.Admin.Controllers
{
    public class aProdukterController : Controller
    {
        KategoriFac kf = new KategoriFac();
        ProdukterFac pf = new ProdukterFac();
        Uploader u = new Uploader();
        // GET: Admin/aProdukter
        public ActionResult Add()
        {
            return View(kf.GetAll());
        }

        [HttpPost]
        public ActionResult AddResult(Produkter pro, HttpPostedFileBase fil)
        {
            if (fil != null)
            {
                string path = Request.PhysicalApplicationPath + "Content/img/";
                pro.Billede = Path.GetFileName(u.UploadImage(fil, path, 300, true));
            }
            else
            {
                pro.Billede = "På vej.jpg";
            }

            pf.Insert(pro);
            ViewBag.MSG = "Produktet er oprettet!";

            return View("Add", kf.GetAll());
        }

        public ActionResult Edit()
        {
            return View(pf.GetAll());
        }

        public ActionResult EditForm(int id)
        {
            return View(pf.Get(id));
        }

        [HttpPost]
        public ActionResult EditResult(Produkter pro)
        {
            if (ModelState.IsValid)
            {
                pf.Update(pro);
            }

            return RedirectToAction("Edit");
        }


        public ActionResult Delete(int id)
        {
            pf.Delete(id);
            return RedirectToAction("Edit");
        }
    }
}