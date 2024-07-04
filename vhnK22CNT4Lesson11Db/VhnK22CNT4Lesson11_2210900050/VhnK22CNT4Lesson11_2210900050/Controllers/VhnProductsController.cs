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
    public class VhnProductsController : Controller
    {
        private VhnK22CNT4Lesson11DbEntities db = new VhnK22CNT4Lesson11DbEntities();

        // GET: VhnProducts
        public ActionResult VhnIndex()
        {
            return View(db.VhnProduct.ToList());
        }

        // GET: VhnProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnProduct vhnProduct = db.VhnProduct.Find(id);
            if (vhnProduct == null)
            {
                return HttpNotFound();
            }
            return View(vhnProduct);
        }

        // GET: VhnProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VhnProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VhnID2210900050,VhnProName,VhnQty,VhnPrice,VhnCateid,VhnActive")] VhnProduct vhnProduct)
        {
            if (ModelState.IsValid)
            {
                db.VhnProduct.Add(vhnProduct);
                db.SaveChanges();
                return RedirectToAction("VhnIndex");
            }

            return View(vhnProduct);
        }

        // GET: VhnProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnProduct vhnProduct = db.VhnProduct.Find(id);
            if (vhnProduct == null)
            {
                return HttpNotFound();
            }
            return View(vhnProduct);
        }

        // POST: VhnProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VhnID2210900050,VhnProName,VhnQty,VhnPrice,VhnCateid,VhnActive")] VhnProduct vhnProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vhnProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("VhnIndex");
            }
            return View(vhnProduct);
        }

        // GET: VhnProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnProduct vhnProduct = db.VhnProduct.Find(id);
            if (vhnProduct == null)
            {
                return HttpNotFound();
            }
            return View(vhnProduct);
        }

        // POST: VhnProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            VhnProduct vhnProduct = db.VhnProduct.Find(id);
            db.VhnProduct.Remove(vhnProduct);
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
