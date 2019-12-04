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
    public class JobDetailsController : Controller
    {
        private MvcProjectdb db = new MvcProjectdb();

        // GET: Admin/JobDetails
        public ActionResult Index()
        {
            return View(db.JobDetails.ToList());
        }

        // GET: Admin/JobDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDetails jobDetails = db.JobDetails.Find(id);
            if (jobDetails == null)
            {
                return HttpNotFound();
            }
            return View(jobDetails);
        }

        // GET: Admin/JobDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/JobDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Desc,Qualification,Responsibilities,Photo")] JobDetails jobDetails)
        {
            if (ModelState.IsValid)
            {
                db.JobDetails.Add(jobDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobDetails);
        }

        // GET: Admin/JobDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDetails jobDetails = db.JobDetails.Find(id);
            if (jobDetails == null)
            {
                return HttpNotFound();
            }
            return View(jobDetails);
        }

        // POST: Admin/JobDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Desc,Qualification,Responsibilities,Photo")] JobDetails jobDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobDetails);
        }

        // GET: Admin/JobDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobDetails jobDetails = db.JobDetails.Find(id);
            if (jobDetails == null)
            {
                return HttpNotFound();
            }
            return View(jobDetails);
        }

        // POST: Admin/JobDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobDetails jobDetails = db.JobDetails.Find(id);
            db.JobDetails.Remove(jobDetails);
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
