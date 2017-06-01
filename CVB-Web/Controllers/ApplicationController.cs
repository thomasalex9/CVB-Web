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
    public class ApplicationController : Controller
    {
        private meradia_db db = new meradia_db();

        // GET: Application
        public ActionResult Index()
        {
            var applications = db.applications.Include(a => a.app_domain).Include(a => a.app_vendor);
            return View(applications.ToList());
        }

        // GET: Application/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            application application = db.applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // GET: Application/Create
        public ActionResult Create()
        {
            ViewBag.app_domain_id = new SelectList(db.app_domain, "ID", "app_domain_nm");
            ViewBag.app_vendor_id = new SelectList(db.app_vendor, "ID", "app_vendor_nm");
            return View();
        }

        // POST: Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,application_nm,application_descr,app_vendor_id,app_domain_id,formal_nm")] application application)
        {
            if (ModelState.IsValid)
            {
                db.applications.Add(application);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.app_domain_id = new SelectList(db.app_domain, "ID", "app_domain_nm", application.app_domain_id);
            ViewBag.app_vendor_id = new SelectList(db.app_vendor, "ID", "app_vendor_nm", application.app_vendor_id);
            return View(application);
        }

        // GET: Application/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            application application = db.applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            ViewBag.app_domain_id = new SelectList(db.app_domain, "ID", "app_domain_nm", application.app_domain_id);
            ViewBag.app_vendor_id = new SelectList(db.app_vendor, "ID", "app_vendor_nm", application.app_vendor_id);
            return View(application);
        }

        // POST: Application/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,application_nm,application_descr,app_vendor_id,app_domain_id,formal_nm")] application application)
        {
            if (ModelState.IsValid)
            {
                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.app_domain_id = new SelectList(db.app_domain, "ID", "app_domain_nm", application.app_domain_id);
            ViewBag.app_vendor_id = new SelectList(db.app_vendor, "ID", "app_vendor_nm", application.app_vendor_id);
            return View(application);
        }

        // GET: Application/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            application application = db.applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            application application = db.applications.Find(id);
            db.applications.Remove(application);
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
