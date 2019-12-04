using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeworkMvc.Data;
using HomeworkMvc.Models;

namespace HomeworkMvc.Areas.Admin.Controllers
{
    public class CandidateListingsController : Controller
    {
        private MvcProjectdb db = new MvcProjectdb();

        // GET: Admin/CandidateListings
        public ActionResult Index()
        {
            return View(db.CandidateListings.ToList());
        }

        // GET: Admin/CandidateListings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidateListing candidateListing = db.CandidateListings.Find(id);
            if (candidateListing == null)
            {
                return HttpNotFound();
            }
            return View(candidateListing);
        }

        // GET: Admin/CandidateListings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CandidateListings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,PhotoItem,Icon,Work,Location,Price,Skills")] CandidateListing candidateListing)
        {
            if (ModelState.IsValid)
            {
                db.CandidateListings.Add(candidateListing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidateListing);
        }

        // GET: Admin/CandidateListings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidateListing candidateListing = db.CandidateListings.Find(id);
            if (candidateListing == null)
            {
                return HttpNotFound();
            }
            return View(candidateListing);
        }

        // POST: Admin/CandidateListings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,PhotoItem,Icon,Work,Location,Price,Skills")] CandidateListing candidateListing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candidateListing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(candidateListing);
        }

        // GET: Admin/CandidateListings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CandidateListing candidateListing = db.CandidateListings.Find(id);
            if (candidateListing == null)
            {
                return HttpNotFound();
            }
            return View(candidateListing);
        }

        // POST: Admin/CandidateListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CandidateListing candidateListing = db.CandidateListings.Find(id);
            db.CandidateListings.Remove(candidateListing);
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
