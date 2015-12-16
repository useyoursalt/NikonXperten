using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNX;

namespace NikonXperten.Areas.Admin.Controllers
{
    public class aKontaktController : Controller
    {
        KontaktFac kf = new KontaktFac();
        Uploader u = new Uploader();
        

        public ActionResult EditForm()
        {
            return View(kf.Get(1));
        }

        [HttpPost]
        public ActionResult EditResult(Kontakt kon)
        {
            if (ModelState.IsValid)
            {
                kf.Update(kon);
            }

            return RedirectToAction("EditForm");
        }
    }
}