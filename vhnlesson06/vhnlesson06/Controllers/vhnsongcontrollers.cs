using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vhnlesson06.Controllers
{
    public class vhnsongcontrollers : Controller
    {
        private static List<Models.VhnSong1> vhnSong1s = new List<Models.VhnSong1>()
        {
          new Models.VhnSong1{Id = "2210900050", VhnTitle = "Vu Hoai Nam", VhnArtist = "NTU", vhnAuthor = "K22CNT4", vhnYearRelease = "2020"},
          new Models.VhnSong1{Id = "2210900030", VhnTitle = "Nguyen Van Quyet", VhnArtist = "NTU", vhnAuthor = "K22CNT4", vhnYearRelease = "2020"}
        };
        // GET: vhnsongcontrollers
        public ActionResult VhnIndex()
        {
            return View(vhnSong1s);
        }
        public ActionResult vhnCreate()
        {
            var vhnsong = new Models.VhnSong1();
            return View(vhnsong);
        }
    }
}