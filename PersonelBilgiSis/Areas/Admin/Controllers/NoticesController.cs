using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonelBilgiSis;
using PersonnelInformationSystem.Areas.Admin.Models;
using PersonelBilgiSis.Models;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class NoticesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/Notices
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.Notices.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/Notices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notices notices = db.Notices.Find(id);
            if (notices == null)
            {
                return HttpNotFound();
            }
            return View(notices);
        }

        // GET: Admin/Notices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Notices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoticeId,Sites,NoticeTitle")] Notices notices)
        {
            if (ModelState.IsValid)
            {
                db.Notices.Add(notices);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notices);
        }

        // GET: Admin/Notices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notices notices = db.Notices.Find(id);
            if (notices == null)
            {
                return HttpNotFound();
            }
            return View(notices);
        }

        // POST: Admin/Notices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoticeId,Sites,NoticeTitle")] Notices notices)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notices).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notices);
        }

        // GET: Admin/Notices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notices notices = db.Notices.Find(id);
            if (notices == null)
            {
                return HttpNotFound();
            }
            return View(notices);
        }

        // POST: Admin/Notices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notices notices = db.Notices.Find(id);
            db.Notices.Remove(notices);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
