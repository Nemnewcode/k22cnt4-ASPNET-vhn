using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson02_VHN.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.name = "Vu Hoai Nam - 2210900050";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string Getname()
        {
            return "Vu Hoai Nam - 2210900050";
        }
        public JsonResult Listname()
        {
            string[] names = { "Trinh", "Nguyen", "Phuc", "Truong" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}