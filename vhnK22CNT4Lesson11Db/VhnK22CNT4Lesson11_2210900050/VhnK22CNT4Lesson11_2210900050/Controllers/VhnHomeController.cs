using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VhnK22CNT4Lesson11_2210900050.Controllers
{
    public class VhnHomeController : Controller
    {
        public ActionResult VhnIndex()
        {
            return View();
        }

        public ActionResult VhnAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult VhnContact()
        {
            ViewBag.msv = "2210900050";
            ViewBag.FullName = "Vũ Hoài Nam";

            return View();
        }
    }
}