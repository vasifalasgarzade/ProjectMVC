using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using HomeworkMvc.Areas.Admin.Models;
using HomeworkMvc.Data;
using HomeworkMvc.Models;

namespace HomeworkMvc.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly MvcProjectdb db;

        public LoginController()
        {
            db = new MvcProjectdb();
        }
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginIndexModel loginView)
        {
            if (!ModelState.IsValid)
            {
                return View(loginView);
            }

            HomeworkMvc.Models.Admin adminPanel = db.Admins.FirstOrDefault(a => a.Email == loginView.Email);

            if (adminPanel != null && Crypto.VerifyHashedPassword(adminPanel.Password, loginView.Password))
            {
                adminPanel.Token = Guid.NewGuid().ToString();

                db.SaveChanges();

                HttpCookie cookie = new HttpCookie("token", adminPanel.Token)
                {
                    HttpOnly = true,
                    Expires = loginView.RememberMe ? DateTime.Now.AddYears(1) : DateTime.MinValue
                };

                Response.Cookies.Add(cookie);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "E-poçt və ya şifrə yalnışdır");

            return View(loginView);
        }

    }
}