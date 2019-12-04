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
    public class jobListsController : Controller
    {
        private MvcProjectdb db = new MvcProjectdb();

        // GET: Admin/jobLists
        public ActionResult Index()
        {
            return View(db.JobLists.ToList());
        }

        // GET: Admin/jobLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobList jobList = db.JobLists.Find(id);
            if (jobList == null)
            {
                return HttpNotFound();
            }
            return View(jobList);
        }

        // GET: Admin/jobLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/jobLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Work,Title,Icon,Location,Date,Working")] jobList jobList)
        {
            if (ModelState.IsValid)
            {
                db.JobLists.Add(jobList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobList);
        }

        // GET: Admin/jobLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobList jobList = db.JobLists.Find(id);
            if (jobList == null)
            {
                return HttpNotFound();
            }
            return View(jobList);
        }

        // POST: Admin/jobLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Work,Title,Icon,Location,Date,Working")] jobList jobList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobList);
        }

        // GET: Admin/jobLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jobList jobList = db.JobLists.Find(id);
            if (jobList == null)
            {
                return HttpNotFound();
            }
            return View(jobList);
        }

        // POST: Admin/jobLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            jobList jobList = db.JobLists.Find(id);
            db.JobLists.Remove(jobList);
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
