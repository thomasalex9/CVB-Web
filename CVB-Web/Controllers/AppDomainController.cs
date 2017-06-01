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
    public class AppDomainController : Controller
    {
        private meradia_db db = new meradia_db();

        // GET: AppDomain
        public ActionResult Index()
        {
            return View(db.app_domain.ToList());
        }

        // GET: AppDomain/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_domain app_domain = db.app_domain.Find(id);
            if (app_domain == null)
            {
                return HttpNotFound();
            }
            return View(app_domain);
        }

        // GET: AppDomain/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppDomain/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,app_domain_nm")] app_domain app_domain)
        {
            if (ModelState.IsValid)
            {
                db.app_domain.Add(app_domain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(app_domain);
        }

        // GET: AppDomain/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_domain app_domain = db.app_domain.Find(id);
            if (app_domain == null)
            {
                return HttpNotFound();
            }
            return View(app_domain);
        }

        // POST: AppDomain/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,app_domain_nm")] app_domain app_domain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(app_domain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(app_domain);
        }

        // GET: AppDomain/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            app_domain app_domain = db.app_domain.Find(id);
            if (app_domain == null)
            {
                return HttpNotFound();
            }
            return View(app_domain);
        }

        // POST: AppDomain/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            app_domain app_domain = db.app_domain.Find(id);
            db.app_domain.Remove(app_domain);
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
