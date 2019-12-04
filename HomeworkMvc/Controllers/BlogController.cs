using HomeworkMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkMvc.Controllers
{
    public class BlogController : Controller
    {
        public MvcProjectdb db;
        public BlogController()
        {
            db = new MvcProjectdb();
        }
        // GET: Blog
        public ActionResult List()
        {
            return View(db.BlogLists.ToList());
        }
        public ActionResult Grid()
        {
            return View(db.BlogGrids.ToList());
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}