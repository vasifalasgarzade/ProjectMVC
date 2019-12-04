using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkMvc.Data;
using HomeworkMvc.ViewModels;

namespace HomeworkMvc.Controllers
{
    public class HomeController : Controller
    {
        public MvcProjectdb db;
        public HomeController()
        {
            db = new MvcProjectdb();
        }

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Home = db.Homes.FirstOrDefault(),
                PopularCardItems = db.PopularCardItems.ToList(),
                FindYourJobs = db.FindYourJobs.ToList(),
                HowItWorks = db.HowItWorks.ToList(),
                OurCareers = db.OurCareers.ToList(),
                OurClients = db.OurClients.ToList(),
                OurStories = db.OurStories.ToList()
            };
            return View(model);
        }

       
    }
}