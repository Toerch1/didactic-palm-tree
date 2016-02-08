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
    public class TimeOffRequestsController : Controller
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: TimeOffRequests
        public ActionResult Index()
        {
            return View(db.TimeOffRequests.ToList());
        }

        // GET: TimeOffRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeOffRequest timeOffRequest = db.TimeOffRequests.Find(id);
            if (timeOffRequest == null)
            {
                return HttpNotFound();
            }
            return View(timeOffRequest);
        }

        // GET: TimeOffRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeOffRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EmpId,RequestDate,StartDate,EndDate,Reviewer")] TimeOffRequest timeOffRequest)
        {
            if (ModelState.IsValid)
            {
                db.TimeOffRequests.Add(timeOffRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timeOffRequest);
        }

        // GET: TimeOffRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeOffRequest timeOffRequest = db.TimeOffRequests.Find(id);
            if (timeOffRequest == null)
            {
                return HttpNotFound();
            }
            return View(timeOffRequest);
        }

        // POST: TimeOffRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EmpId,RequestDate,StartDate,EndDate,Reviewer")] TimeOffRequest timeOffRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeOffRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeOffRequest);
        }

        // GET: TimeOffRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeOffRequest timeOffRequest = db.TimeOffRequests.Find(id);
            if (timeOffRequest == null)
            {
                return HttpNotFound();
            }
            return View(timeOffRequest);
        }

        // POST: TimeOffRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeOffRequest timeOffRequest = db.TimeOffRequests.Find(id);
            db.TimeOffRequests.Remove(timeOffRequest);
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
