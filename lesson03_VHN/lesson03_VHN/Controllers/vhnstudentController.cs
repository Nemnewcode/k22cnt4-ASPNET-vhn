using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson03_VHN.Controllers
{
    public class vhnstudentController : Controller
    {
        // GET: vhnstudent
        public ActionResult Index()
        {
            //du lieu tu viewdata
            ViewData["msg"] = "View Data - Vu Hoai Nam";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult Studentlist()
        {
            //su dung viewbag
            //luu tru gia tri don
            ViewBag.titlename = "Danh sach hoc vien - Vu Hoai Nam";
            //Gia tri la 1 tap hop 
            string[] names = { "Bui Phuc", "Dang Nguyen", "Van Quyet" };
            ViewBag.list = names;

            //gia tri la 1 doi tuong
            var obj = new
            {
                ID = 100,
                Name = "Nam",
                Age = 20,
            };
            ViewBag.student = obj;
            return View();
        }

        public ActionResult Insert()
        {
            return View("Addstudent");
        }
    }
}