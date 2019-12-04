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
    public class JobsGridsController : Controller
    {
        private MvcProjectdb db = new MvcProjectdb();

        // GET: Admin/JobsGrids
        public ActionResult Index()
        {
            return View(db.JobsGrids.ToList());
        }

        // GET: Admin/JobsGrids/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsGrid jobsGrid = db.JobsGrids.Find(id);
            if (jobsGrid == null)
            {
                return HttpNotFound();
            }
            return View(jobsGrid);
        }

        // GET: Admin/JobsGrids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/JobsGrids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Icon,Work,Location,Count,Experience")] JobsGrid jobsGrid)
        {
            if (ModelState.IsValid)
            {
                db.JobsGrids.Add(jobsGrid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobsGrid);
        }

        // GET: Admin/JobsGrids/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsGrid jobsGrid = db.JobsGrids.Find(id);
            if (jobsGrid == null)
            {
                return HttpNotFound();
            }
            return View(jobsGrid);
        }

        // POST: Admin/JobsGrids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Icon,Work,Location,Count,Experience")] JobsGrid jobsGrid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobsGrid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobsGrid);
        }

        // GET: Admin/JobsGrids/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsGrid jobsGrid = db.JobsGrids.Find(id);
            if (jobsGrid == null)
            {
                return HttpNotFound();
            }
            return View(jobsGrid);
        }

        // POST: Admin/JobsGrids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobsGrid jobsGrid = db.JobsGrids.Find(id);
            db.JobsGrids.Remove(jobsGrid);
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
