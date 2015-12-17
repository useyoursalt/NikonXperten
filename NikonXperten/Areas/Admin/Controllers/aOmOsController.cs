using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNX;

namespace NikonXperten.Areas.Admin.Controllers
{
    public class aOmOsController : Controller
    {
        OmOsFac of = new OmOsFac();

        [Authorize]
        public ActionResult EditForm()
        {
            return View(of.Get(1));
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditResult(OmOs oo)
        {
            if (ModelState.IsValid)
            {
                of.Update(oo);
            }

            return RedirectToAction("EditForm");
        }
    }
}