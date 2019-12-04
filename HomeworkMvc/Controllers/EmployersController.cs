using HomeworkMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkMvc.Controllers
{
    public class EmployersController : Controller
    {
        public MvcProjectdb db;
        public EmployersController()
        {
            db = new MvcProjectdb();
        }
        // GET: Employers
        public ActionResult List()
        {
            return View(db.EmployersLists.ToList());
        }
        public ActionResult Detail()
        {
            return View();
        }
    }
}