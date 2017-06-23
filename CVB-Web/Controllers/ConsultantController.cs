using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CVB_Web.Models;
using System.Web.ModelBinding;

namespace CVB_Web.Controllers
{
    public class ConsultantController : Controller
    {
        private meradia_db db = new meradia_db();

        // GET: Consultant
        public ActionResult Index([Form] QueryOptions p_QueryOptions, string title )  {

            // we support filtering on Title
            if (String.IsNullOrEmpty(p_QueryOptions.FilterField)) {
                p_QueryOptions.FilterField = "Title";
            }

            var consultants = db.consultants.Include(c => c.title);

            // get a list of distinct titles from the list of consultants
            var title_list = consultants.OrderBy(c => c.title.title_nm).Select(c => c.title.title_nm).Distinct();
            p_QueryOptions.FilterList = new SelectList(title_list);

            // check for any search string.  note that search takes
            // precedence over filter, and is therefore applied first
            if (!String.IsNullOrEmpty(p_QueryOptions.Search)) {
                consultants = consultants.Where(
                    c => c.consultant_nm.Contains(p_QueryOptions.Search) ||
                    c.consultant_initials.Contains(p_QueryOptions.Search));
            }

            // check for the "title" filter.  
            if (!String.IsNullOrEmpty(p_QueryOptions.FilterValue)) {
                consultants = consultants.Where(c => c.title.title_nm == p_QueryOptions.FilterValue);
            }

            // the queryOptions parameter determines which column, if any, is being
            // sorted, and the direction of the sort (ASC or DESC)
            consultants = consultants.OrderBy(p_QueryOptions.Sort);

            ViewBag.QueryOptions = p_QueryOptions;
        
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
