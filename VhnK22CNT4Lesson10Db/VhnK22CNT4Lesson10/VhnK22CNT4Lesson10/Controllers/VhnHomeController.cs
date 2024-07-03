using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VhnK22CNT4Lesson10.Controllers
{
    public class VhnHomeController : Controller
    {
        public ActionResult VhnIndex()
        {
            if (Session["VhnAccount"] != null)
            {
                var vhnAccount = Session["VhnAccount"] as VhnAccount;
                ViewBag.FullName = vhnAccount.VhnFullName;
            }
            return View();
        }

        public ActionResult VhnAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult VhnContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}