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
    public class FuelTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FuelTypes
        public ActionResult Index()
        {
            return View(db.Fuels.ToList());
        }

        // GET: FuelTypes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelType fuelType = db.Fuels.Find(id);
            if (fuelType == null)
            {
                return HttpNotFound();
            }
            return View(fuelType);
        }

        // GET: FuelTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuelTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                db.Fuels.Add(fuelType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fuelType);
        }

        // GET: FuelTypes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelType fuelType = db.Fuels.Find(id);
            if (fuelType == null)
            {
                return HttpNotFound();
            }
            return View(fuelType);
        }

        // POST: FuelTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fuelType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fuelType);
        }

        // GET: FuelTypes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FuelType fuelType = db.Fuels.Find(id);
            if (fuelType == null)
            {
                return HttpNotFound();
            }
            return View(fuelType);
        }

        // POST: FuelTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            FuelType fuelType = db.Fuels.Find(id);
            db.Fuels.Remove(fuelType);
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
