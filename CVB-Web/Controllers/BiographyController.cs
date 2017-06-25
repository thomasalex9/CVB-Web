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
    public class BiographyController : Controller
    {
        private meradia_db db = new meradia_db();

        // GET: Biography
        public ActionResult Index(int consultant_id)
        {
            var consultant_biography = db.consultant_biography.Where(c => c.consultant_id == consultant_id).Include(c => c.consultant);
            return View(consultant_biography.ToList());
        }

        // GET: Biography/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consultant_biography consultant_biography = db.consultant_biography.Find(id);
            if (consultant_biography == null)
            {
                return HttpNotFound();
            }
            return View(consultant_biography);
        }

        // GET: Biography/Create
        public ActionResult Create()
        {
            ViewBag.consultant_id = new SelectList(db.consultants, "ID", "consultant_nm");
            return View();
        }

        // POST: Biography/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,consultant_id,bio_txt,show,bio_descr,show_RIC")] consultant_biography consultant_biography)
        {
            if (ModelState.IsValid)
            {
                db.consultant_biography.Add(consultant_biography);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.consultant_id = new SelectList(db.consultants, "ID", "consultant_nm", consultant_biography.consultant_id);
            return View(consultant_biography);
        }

        // GET: Biography/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consultant_biography consultant_biography = db.consultant_biography.Find(id);
            if (consultant_biography == null)
            {
                return HttpNotFound();
            }
            //ViewBag.consultant_id = new SelectList(db.consultants, "ID", "consultant_nm", consultant_biography.consultant_id);
            return View(consultant_biography);
        }

        // POST: Biography/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,consultant_id,bio_txt,show,bio_descr,show_RIC")] consultant_biography consultant_biography)
        {
            if (ModelState.IsValid) {
                db.Entry(consultant_biography).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index",new { consultant_id = consultant_biography.consultant_id });
            }
            //ViewBag.consultant_id = new SelectList(db.consultants, "ID", "consultant_nm", consultant_biography.consultant_id);
            return View(consultant_biography);
        }

        // GET: Biography/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consultant_biography consultant_biography = db.consultant_biography.Find(id);
            if (consultant_biography == null)
            {
                return HttpNotFound();
            }
            return View(consultant_biography);
        }

        // POST: Biography/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            consultant_biography consultant_biography = db.consultant_biography.Find(id);
            db.consultant_biography.Remove(consultant_biography);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
