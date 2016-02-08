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
    public class SchedDaysController : Controller
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: SchedDays
        public ActionResult Index()
        {
            return View(db.SchedDayss.ToList());
        }

        // GET: SchedDays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchedDays schedDays = db.SchedDayss.Find(id);
            if (schedDays == null)
            {
                return HttpNotFound();
            }
            return View(schedDays);
        }

        // GET: SchedDays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchedDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Day")] SchedDays schedDays)
        {
            if (ModelState.IsValid)
            {
                db.SchedDayss.Add(schedDays);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schedDays);
        }

        // GET: SchedDays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchedDays schedDays = db.SchedDayss.Find(id);
            if (schedDays == null)
            {
                return HttpNotFound();
            }
            return View(schedDays);
        }

        // POST: SchedDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Day")] SchedDays schedDays)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schedDays).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schedDays);
        }

        // GET: SchedDays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchedDays schedDays = db.SchedDayss.Find(id);
            if (schedDays == null)
            {
                return HttpNotFound();
            }
            return View(schedDays);
        }

        // POST: SchedDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SchedDays schedDays = db.SchedDayss.Find(id);
            db.SchedDayss.Remove(schedDays);
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
