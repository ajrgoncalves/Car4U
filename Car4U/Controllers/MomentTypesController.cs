using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Car4U.DAL;
using Car4U.Models;

namespace Car4U.Controllers
{
    public class MomentTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MomentTypes
        public ActionResult Index()
        {
            return View(db.MomentTypes.ToList());
        }

        // GET: MomentTypes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MomentType momentType = db.MomentTypes.Find(id);
            if (momentType == null)
            {
                return HttpNotFound();
            }
            return View(momentType);
        }

        // GET: MomentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MomentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] MomentType momentType)
        {
            if (ModelState.IsValid)
            {
                db.MomentTypes.Add(momentType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(momentType);
        }

        // GET: MomentTypes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MomentType momentType = db.MomentTypes.Find(id);
            if (momentType == null)
            {
                return HttpNotFound();
            }
            return View(momentType);
        }

        // POST: MomentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description")] MomentType momentType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(momentType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(momentType);
        }

        // GET: MomentTypes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MomentType momentType = db.MomentTypes.Find(id);
            if (momentType == null)
            {
                return HttpNotFound();
            }
            return View(momentType);
        }

        // POST: MomentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MomentType momentType = db.MomentTypes.Find(id);
            db.MomentTypes.Remove(momentType);
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
