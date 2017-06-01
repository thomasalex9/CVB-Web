using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CVB_Web.Models;

namespace CVB_Web.Controllers
{
    public class AppVendorController : Controller
    {
        private meradia_db db = new meradia_db();

        // GET: AppVendor
        public ActionResult Index()
        {
            return View(db.app_vendor.ToList());
        }

        // GET: AppVendor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_vendor app_vendor = db.app_vendor.Find(id);
            if (app_vendor == null)
            {
                return HttpNotFound();
            }
            return View(app_vendor);
        }

        // GET: AppVendor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppVendor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,app_vendor_nm")] app_vendor app_vendor)
        {
            if (ModelState.IsValid)
            {
                db.app_vendor.Add(app_vendor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(app_vendor);
        }

        // GET: AppVendor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_vendor app_vendor = db.app_vendor.Find(id);
            if (app_vendor == null)
            {
                return HttpNotFound();
            }
            return View(app_vendor);
        }

        // POST: AppVendor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,app_vendor_nm")] app_vendor app_vendor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(app_vendor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(app_vendor);
        }

        // GET: AppVendor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_vendor app_vendor = db.app_vendor.Find(id);
            if (app_vendor == null)
            {
                return HttpNotFound();
            }
            return View(app_vendor);
        }

        // POST: AppVendor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app_vendor app_vendor = db.app_vendor.Find(id);
            db.app_vendor.Remove(app_vendor);
            db.SaveChanges();
            return RedirectToAction("Index");
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
