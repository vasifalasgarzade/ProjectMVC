using HomeworkMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkMvc.Controllers
{
    public class CandidatesController : Controller
    {
        public MvcProjectdb db;
        public CandidatesController()
        {
            db = new MvcProjectdb();
        }
        // GET: Candidates
        public ActionResult Listing()
        {


            return View(db.CandidateListings.ToList());
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult CreateResume()
        {
            return View();
        }
    }
}