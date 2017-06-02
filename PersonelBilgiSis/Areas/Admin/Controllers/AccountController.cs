using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        DB db = new DB();
        // GET: Admin/Account
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
        [HttpPost]
        public ActionResult Index(User usr)
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User account)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(account);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = account.UserNameSurname + "" + "Succesfully registered";

            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var usr = db.Users.Single(u => u.Email == user.Email && u.PasswordHash == user.PasswordHash);
                if (usr != null)
                {
                    Session["User"] = usr;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password is wrog.");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
