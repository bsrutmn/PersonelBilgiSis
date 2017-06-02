using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonelBilgiSis;
using PersonelBilgiSis.Areas.Admin.Models;
using PersonelBilgiSis.Models;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class GivenLessonsController : Controller
    {
        private DB db = new DB();

        // GET: Admin/GivenLessons
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.GivenLessons.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/GivenLessons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GivenLessons givenLessons = db.GivenLessons.Find(id);
            if (givenLessons == null)
            {
                return HttpNotFound();
            }
            return View(givenLessons);
        }

        // GET: Admin/GivenLessons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/GivenLessons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LessonId,Sites,LessonName")] GivenLessons givenLessons)
        {
            if (ModelState.IsValid)
            {
                db.GivenLessons.Add(givenLessons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(givenLessons);
        }

        // GET: Admin/GivenLessons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GivenLessons givenLessons = db.GivenLessons.Find(id);
            if (givenLessons == null)
            {
                return HttpNotFound();
            }
            return View(givenLessons);
        }

        // POST: Admin/GivenLessons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LessonId,Sites,LessonName")] GivenLessons givenLessons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(givenLessons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(givenLessons);
        }

        // GET: Admin/GivenLessons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GivenLessons givenLessons = db.GivenLessons.Find(id);
            if (givenLessons == null)
            {
                return HttpNotFound();
            }
            return View(givenLessons);
        }

        // POST: Admin/GivenLessons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GivenLessons givenLessons = db.GivenLessons.Find(id);
            db.GivenLessons.Remove(givenLessons);
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
