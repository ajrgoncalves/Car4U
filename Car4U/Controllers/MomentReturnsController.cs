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
    public class MomentReturnsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MomentReturns
        public ActionResult Index()
        {
            return View(db.MomentTypes.ToList());
        }

        // GET: MomentReturns/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MomentReturn momentReturn = db.MomentTypes.Find(id);
            if (momentReturn == null)
            {
                return HttpNotFound();
            }
            return View(momentReturn);
        }

        // GET: MomentReturns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MomentReturns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Observation")] MomentReturn momentReturn)
        {
            if (ModelState.IsValid)
            {
                db.MomentTypes.Add(momentReturn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(momentReturn);
        }

        // GET: MomentReturns/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MomentReturn momentReturn = db.MomentTypes.Find(id);
            if (momentReturn == null)
            {
                return HttpNotFound();
            }
            return View(momentReturn);
        }

        // POST: MomentReturns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,Observation")] MomentReturn momentReturn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(momentReturn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(momentReturn);
        }

        // GET: MomentReturns/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MomentReturn momentReturn = db.MomentTypes.Find(id);
            if (momentReturn == null)
            {
                return HttpNotFound();
            }
            return View(momentReturn);
        }

        // POST: MomentReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MomentReturn momentReturn = db.MomentTypes.Find(id);
            db.MomentTypes.Remove(momentReturn);
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
