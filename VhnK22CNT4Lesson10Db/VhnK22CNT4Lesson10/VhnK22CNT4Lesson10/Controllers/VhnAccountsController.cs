using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VhnK22CNT4Lesson10.Models;

namespace VhnK22CNT4Lesson10.Controllers
{
    public class VhnAccountsController : Controller
    {
        private VhnCNT4Lesson10DbEntities db = new VhnCNT4Lesson10DbEntities();

        // GET: VhnAccounts
        public ActionResult VhnIndex()
        {
            return View(db.VhnAccount.ToList());
        }

        // GET: VhnAccounts/Details/5
        public ActionResult VhnDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnAccount vhnAccount = db.VhnAccount.Find(id);
            if (vhnAccount == null)
            {
                return HttpNotFound();
            }
            return View(vhnAccount);
        }

        // GET: VhnAccounts/Create
        public ActionResult VhnCreate()
        {
            return View();
        }

        // POST: VhnAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VhnCreate([Bind(Include = "VhnID,VhnUserName,VhnPassword,VhnFullName,VhnEmail,VhnPhone,VhnActive")] VhnAccount vhnAccount)
        {
            if (ModelState.IsValid)
            {
                db.VhnAccount.Add(vhnAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vhnAccount);
        }

        // GET: VhnAccounts/Edit/5
        public ActionResult VhnEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnAccount vhnAccount = db.VhnAccount.Find(id);
            if (vhnAccount == null)
            {
                return HttpNotFound();
            }
            return View(vhnAccount);
        }

        // POST: VhnAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VhnID,VhnUserName,VhnPassword,VhnFullName,VhnEmail,VhnPhone,VhnActive")] VhnAccount vhnAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vhnAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vhnAccount);
        }

        // GET: VhnAccounts/Delete/5
        public ActionResult VhnDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VhnAccount vhnAccount = db.VhnAccount.Find(id);
            if (vhnAccount == null)
            {
                return HttpNotFound();
            }
            return View(vhnAccount);
        }

        // POST: VhnAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VhnAccount vhnAccount = db.VhnAccount.Find(id);
            db.VhnAccount.Remove(vhnAccount);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void VhnDispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        //login
        public ActionResult VhnLogin()
        {
            var VhnModel = new VhnAccount();
            return View(VhnModel);
        }
        [HttpPost]
        public ActionResult VhnLogin(VhnAccount vhnAccount)
        {
            var vhnCheck = db.VhnAccount.Where(x => x.VhnUserName.Equals(vhnAccount.VhnUserName) && x.VhnPassword.Equals(vhnAccount.VhnPassword)).FirstOrDefault();
            if(vhnCheck != null)
            {
                Session["VhnAccount"] = vhnCheck;
                return Redirect("/");
            }
            return View(vhnAccount);

        }
    }
}
