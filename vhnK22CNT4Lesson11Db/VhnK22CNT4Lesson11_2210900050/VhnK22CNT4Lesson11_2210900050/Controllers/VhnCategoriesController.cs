using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VhnK22CNT4Lesson11_2210900050.Models;

namespace VhnK22CNT4Lesson11_2210900050.Controllers
{
    public class VhnCategoriesController : Controller
    {
        private VhnK22CNT4Lesson11DbEntities db = new VhnK22CNT4Lesson11DbEntities();

        // GET: VhnCategories
        public ActionResult VhnIndex()
        {
            return View(db.VhnCategory.ToList());
        }

        // GET: VhnCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnCategory vhnCategory = db.VhnCategory.Find(id);
            if (vhnCategory == null)
            {
                return HttpNotFound();
            }
            return View(vhnCategory);
        }

        // GET: VhnCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VhnCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VhnID,VhnCateName,VhnStatus")] VhnCategory vhnCategory)
        {
            if (ModelState.IsValid)
            {
                db.VhnCategory.Add(vhnCategory);
                db.SaveChanges();
                return RedirectToAction("VhnIndex");
            }

            return View(vhnCategory);
        }

        // GET: VhnCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnCategory vhnCategory = db.VhnCategory.Find(id);
            if (vhnCategory == null)
            {
                return HttpNotFound();
            }
            return View(vhnCategory);
        }

        // POST: VhnCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VhnID,VhnCateName,VhnStatus")] VhnCategory vhnCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vhnCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VhnIndex");
            }
            return View(vhnCategory);
        }

        // GET: VhnCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnCategory vhnCategory = db.VhnCategory.Find(id);
            if (vhnCategory == null)
            {
                return HttpNotFound();
            }
            return View(vhnCategory);
        }

        // POST: VhnCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VhnCategory vhnCategory = db.VhnCategory.Find(id);
            db.VhnCategory.Remove(vhnCategory);
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
