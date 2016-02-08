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
    public class EmpSchedsController : Controller
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: EmpScheds
        public ActionResult Index()
        {
            return View(db.EmpScheds.ToList());
        }

        // GET: EmpScheds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpSched empSched = db.EmpScheds.Find(id);
            if (empSched == null)
            {
                return HttpNotFound();
            }
            return View(empSched);
        }

        // GET: EmpScheds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpScheds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpID,SchedID,StartDate,EndDate")] EmpSched empSched)
        {
            if (ModelState.IsValid)
            {
                db.EmpScheds.Add(empSched);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empSched);
        }

        // GET: EmpScheds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpSched empSched = db.EmpScheds.Find(id);
            if (empSched == null)
            {
                return HttpNotFound();
            }
            return View(empSched);
        }

        // POST: EmpScheds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpID,SchedID,StartDate,EndDate")] EmpSched empSched)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empSched).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empSched);
        }

        // GET: EmpScheds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpSched empSched = db.EmpScheds.Find(id);
            if (empSched == null)
            {
                return HttpNotFound();
            }
            return View(empSched);
        }

        // POST: EmpScheds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpSched empSched = db.EmpScheds.Find(id);
            db.EmpScheds.Remove(empSched);
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
