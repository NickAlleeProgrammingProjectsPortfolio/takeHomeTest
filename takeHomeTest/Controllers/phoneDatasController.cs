using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using takeHomeTest.DAL;
using takeHomeTest.Models;

namespace takeHomeTest.Controllers
{
    public class phoneDatasController : Controller
    {
        private workContext db = new workContext();

        // GET: phoneDatas
        public ActionResult Index()
        {
            return View(db.phoneData.ToList());
        }

        // GET: phoneDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phoneData phoneData = db.phoneData.Find(id);
            if (phoneData == null)
            {
                return HttpNotFound();
            }
            return View(phoneData);
        }

        // GET: phoneDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: phoneDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Brand,ownerFirstName,timestamp")] phoneData phoneData)
        {
            if (ModelState.IsValid)
            {
                db.phoneData.Add(phoneData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phoneData);
        }

        // GET: phoneDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phoneData phoneData = db.phoneData.Find(id);
            if (phoneData == null)
            {
                return HttpNotFound();
            }
            return View(phoneData);
        }

        // POST: phoneDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Brand,ownerFirstName,timestamp")] phoneData phoneData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phoneData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phoneData);
        }

        // GET: phoneDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phoneData phoneData = db.phoneData.Find(id);
            if (phoneData == null)
            {
                return HttpNotFound();
            }
            return View(phoneData);
        }

        // POST: phoneDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            phoneData phoneData = db.phoneData.Find(id);
            db.phoneData.Remove(phoneData);
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
