using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkMvc.Controllers
{
    public class PagesController : Controller
    {
        // GET: Page
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Faqs()
        {
            return View();
        }
        public ActionResult PricingPlan()
        {
            return View();
        }
      
    }
}