using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DayCodesController : Controller
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: DayCodes
        public ActionResult Index()
        {
            return View(db.DayCodes.ToList());
        }

        // GET: DayCodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DayCode dayCode = db.DayCodes.Find(id);
            if (dayCode == null)
            {
                return HttpNotFound();
            }
            return View(dayCode);
        }

        // GET: DayCodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DayCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Day")] DayCode dayCode)
        {
            if (ModelState.IsValid)
            {
                db.DayCodes.Add(dayCode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dayCode);
        }

        // GET: DayCodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DayCode dayCode = db.DayCodes.Find(id);
            if (dayCode == null)
            {
                return HttpNotFound();
            }
            return View(dayCode);
        }

        // POST: DayCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Day")] DayCode dayCode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dayCode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dayCode);
        }

        // GET: DayCodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DayCode dayCode = db.DayCodes.Find(id);
            if (dayCode == null)
            {
                return HttpNotFound();
            }
            return View(dayCode);
        }

        // POST: DayCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DayCode dayCode = db.DayCodes.Find(id);
            db.DayCodes.Remove(dayCode);
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
