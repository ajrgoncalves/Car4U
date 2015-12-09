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
    public class CarStatusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CarStatus
        public ActionResult Index()
        {
            return View(db.CarStatus.ToList());
        }

        // GET: CarStatus/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarStatus carStatus = db.CarStatus.Find(id);
            if (carStatus == null)
            {
                return HttpNotFound();
            }
            return View(carStatus);
        }

        // GET: CarStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Observation,BeginDate,FinishDate")] CarStatus carStatus)
        {
            if (ModelState.IsValid)
            {
                db.CarStatus.Add(carStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carStatus);
        }

        // GET: CarStatus/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarStatus carStatus = db.CarStatus.Find(id);
            if (carStatus == null)
            {
                return HttpNotFound();
            }
            return View(carStatus);
        }

        // POST: CarStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Observation,BeginDate,FinishDate")] CarStatus carStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carStatus);
        }

        // GET: CarStatus/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarStatus carStatus = db.CarStatus.Find(id);
            if (carStatus == null)
            {
                return HttpNotFound();
            }
            return View(carStatus);
        }

        // POST: CarStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CarStatus carStatus = db.CarStatus.Find(id);
            db.CarStatus.Remove(carStatus);
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
