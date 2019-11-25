using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkMvc.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Grid()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}