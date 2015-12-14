using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NikonXperten.Areas.Admin.Controllers
{
    public class AdminDefaultController : Controller
    {
        // GET: Admin/AdminDefault
        public ActionResult Index()
        {
            return View();
        }
    }
}