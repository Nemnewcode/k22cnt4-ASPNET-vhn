using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VhnBaiKiemTraGK.Models;

namespace VhnBaiKiemTraGK.Controllers
{
    public class VhnKhoasController : Controller
    {
        private VhnK22CNT4lesson07DbEntities db = new VhnK22CNT4lesson07DbEntities();

        // GET: VhnKhoas
        public ActionResult VhnIndex()
        {
            return View(db.vhnKhoa.ToList());
        }

        // GET: VhnKhoas/Details/5
        public ActionResult VhnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vhnKhoa vhnKhoa = db.vhnKhoa.Find(id);
            if (vhnKhoa == null)
            {
                return HttpNotFound();
            }
            return View(vhnKhoa);
        }

        // GET: VhnKhoas/Create
        public ActionResult VhnCreate()
        {
            return View();
        }

        // POST: VhnKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VhnCreate([Bind(Include = "VhnMaKH,VhnTenKH,VhnTrangThai")] vhnKhoa vhnKhoa)
        {
            if (ModelState.IsValid)
            {
                db.vhnKhoa.Add(vhnKhoa);
                db.SaveChanges();
                return RedirectToAction("VhnIndex");
            }

            return View(vhnKhoa);
        }

        // GET: VhnKhoas/Edit/5
        public ActionResult VhnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vhnKhoa vhnKhoa = db.vhnKhoa.Find(id);
            if (vhnKhoa == null)
            {
                return HttpNotFound();
            }
            return View(vhnKhoa);
        }

        // POST: VhnKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VhnEdit([Bind(Include = "VhnMaKH,VhnTenKH,VhnTrangThai")] vhnKhoa vhnKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vhnKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VhnIndex");
            }
            return View(vhnKhoa);
        }

        // GET: VhnKhoas/Delete/5
        public ActionResult VhnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vhnKhoa vhnKhoa = db.vhnKhoa.Find(id);
            if (vhnKhoa == null)
            {
                return HttpNotFound();
            }
            return View(vhnKhoa);
        }

        // POST: VhnKhoas/Delete/5
        [HttpPost, ActionName("VhnDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult VhnDeleteConfirmed(string id)
        {
            vhnKhoa vhnKhoa = db.vhnKhoa.Find(id);
            db.vhnKhoa.Remove(vhnKhoa);
            db.SaveChanges();
            return RedirectToAction("VhnIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
