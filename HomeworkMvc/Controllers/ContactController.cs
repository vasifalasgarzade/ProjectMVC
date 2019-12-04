using HomeworkMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkMvc.Controllers
{
    public class ContactController : Controller
    {
        public MvcProjectdb db;
        public ContactController()
        {
            db = new MvcProjectdb();
        }
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}