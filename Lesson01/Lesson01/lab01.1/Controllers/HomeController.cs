using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab01._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //sử dụng viewBag để đưa dữ liệu ra view 
            ViewBag.message = "chào mừng bạn đến với ASP.NET MVC 5";
            return View();
        }
        public ActionResult About()
        {
            //sử dụng viewBag để đưa dữ liệu ra view 
            ViewBag.message = "DĐây là trang about";
            return View();
            
        }
    }
}