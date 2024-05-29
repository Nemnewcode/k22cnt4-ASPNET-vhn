    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    namespace Vhn_BaiThiGiuaKy.Controllers
    {
        public class VhnCustomerController : Controller
        {
            private static List<Models.VhnCustomer> vhnCustomers = new List<Models.VhnCustomer>
            { 
              new Models.VhnCustomer{ _2210900050_Cusid = "2210900050", Vhn_Fullname = "Vu Hoai Nam", Vhn_Address = "Ha Noi", Vhn_Email = "hoainem2662gmail.com", 
              Vhn_Phone = "0326630444", Vhn_Balance=1
              },
               new Models.VhnCustomer{ _2210900050_Cusid = "1", Vhn_Fullname = "Nguyen Van Quyet", Vhn_Address = "Ha Noi", Vhn_Email = "vh1134gmail.com",
              Vhn_Phone = "0714500023", Vhn_Balance=1
              },
                new Models.VhnCustomer{ _2210900050_Cusid = "2", Vhn_Fullname = "Dang Tai Nguyen", Vhn_Address = "Ha Noi", Vhn_Email = "hza01gmail.com",
              Vhn_Phone = "0972142566", Vhn_Balance=1
              }
            };
            // GET: VhnCustomer
            public ActionResult VhnIndex()
            {
                return View(vhnCustomers);
            }
            public ActionResult VhnCreate()
            {
                return View();

            }
            [HttpPost]

            public ActionResult VhnCreate(Models.VhnCustomer cus)
            {
                vhnCustomers.Add(cus);
                return RedirectToAction("VhnIndex");
            }
         
        }
    }