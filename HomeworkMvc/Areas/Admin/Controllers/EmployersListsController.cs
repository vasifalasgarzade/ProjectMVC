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
    public class EmployersListsController : Controller
    {
        private MvcProjectdb db = new MvcProjectdb();

        // GET: Admin/EmployersLists
        public ActionResult Index()
        {
            return View(db.EmployersLists.ToList());
        }

        // GET: Admin/EmployersLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployersList employersList = db.EmployersLists.Find(id);
            if (employersList == null)
            {
                return HttpNotFound();
            }
            return View(employersList);
        }

        // GET: Admin/EmployersLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/EmployersLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PhotoItem,FullName,Work,Icon,Location,Rating,HeaderPhoto")] EmployersList employersList)
        {
            if (ModelState.IsValid)
            {
                db.EmployersLists.Add(employersList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employersList);
        }

        // GET: Admin/EmployersLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployersList employersList = db.EmployersLists.Find(id);
            if (employersList == null)
            {
                return HttpNotFound();
            }
            return View(employersList);
        }

        // POST: Admin/EmployersLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PhotoItem,FullName,Work,Icon,Location,Rating,HeaderPhoto")] EmployersList employersList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employersList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employersList);
        }

        // GET: Admin/EmployersLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployersList employersList = db.EmployersLists.Find(id);
            if (employersList == null)
            {
                return HttpNotFound();
            }
            return View(employersList);
        }

        // POST: Admin/EmployersLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployersList employersList = db.EmployersLists.Find(id);
            db.EmployersLists.Remove(employersList);
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
