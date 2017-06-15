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
    public class ConsultantController : Controller
    {
        private meradia_db db = new meradia_db();

        // GET: Consultant
        public ActionResult Index()
        {
            var consultants = db.consultants.Include(c => c.title);
            return View(consultants.ToList());
        }

        // GET: Consultant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consultant consultant = db.consultants.Find(id);
            if (consultant == null)
            {
                return HttpNotFound();
            }
            return View(consultant);
        }

        // GET: Consultant/Create
        public ActionResult Create()
        {
            ViewBag.title_id = new SelectList(db.titles, "ID", "title_nm");
            return View();
        }

        // POST: Consultant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,consultant_nm,title_id,consultant_initials,start_dt,end_dt,image_url,is_admin,is_manager,email_address,noteworthy_intro,birth_dt,headshot,vacation_available")] consultant consultant)
        {
            if (ModelState.IsValid)
            {
                db.consultants.Add(consultant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.title_id = new SelectList(db.titles, "ID", "title_nm", consultant.title_id);
            return View(consultant);
        }

        // GET: Consultant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consultant consultant = db.consultants.Find(id);
            if (consultant == null)
            {
                return HttpNotFound();
            }
            ViewBag.title_id = new SelectList(db.titles, "ID", "title_nm", consultant.title_id);
            return View(consultant);
        }

        // POST: Consultant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,consultant_nm,title_id,consultant_initials,start_dt,end_dt,image_url,is_admin,is_manager,email_address,noteworthy_intro,birth_dt,headshot,vacation_available")] consultant consultant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.title_id = new SelectList(db.titles, "ID", "title_nm", consultant.title_id);
            return View(consultant);
        }

        // GET: Consultant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consultant consultant = db.consultants.Find(id);
            if (consultant == null)
            {
                return HttpNotFound();
            }
            return View(consultant);
        }

        // POST: Consultant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            consultant consultant = db.consultants.Find(id);
            db.consultants.Remove(consultant);
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
