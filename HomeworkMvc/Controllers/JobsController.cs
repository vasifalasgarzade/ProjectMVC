using HomeworkMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkMvc.ViewModels;

namespace HomeworkMvc.Controllers
{
    public class JobsController : Controller
    {

        public MvcProjectdb db;
        public JobsController()
        {
            db = new MvcProjectdb();
        }
        // GET: Jobs
        public ActionResult List()
        {
            JobViewModel model = new JobViewModel
            {
                JobLists = db.JobLists.ToList()
            };
            return View(model);
        }
        public ActionResult Grid()
        {
            JobViewModel model = new JobViewModel
            {
                JobsGrids = db.JobsGrids.ToList()
            };
            return View(model);
        }
        public ActionResult Details()
        {
            JobViewModel model = new JobViewModel
            {
                jobDetail = db.JobDetails.FirstOrDefault(),
                jobDetails = db.JobDetails.ToList()
            };
            return View(model);
        }
        public ActionResult Details2()
        {
            return View();
        }
    }
}