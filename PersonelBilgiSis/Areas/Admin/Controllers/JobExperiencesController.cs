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
    public class JobExperiencesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/JobExperiences
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.JobExperiences.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/JobExperiences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobExperience jobExperience = db.JobExperiences.Find(id);
            if (jobExperience == null)
            {
                return HttpNotFound();
            }
            return View(jobExperience);
        }

        // GET: Admin/JobExperiences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/JobExperiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobID,Birim_Kurum,Gorev,Baslangic,Bitis")] JobExperience jobExperience)
        {
            if (ModelState.IsValid)
            {
                db.JobExperiences.Add(jobExperience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobExperience);
        }

        // GET: Admin/JobExperiences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobExperience jobExperience = db.JobExperiences.Find(id);
            if (jobExperience == null)
            {
                return HttpNotFound();
            }
            return View(jobExperience);
        }

        // POST: Admin/JobExperiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobID,Birim_Kurum,Gorev,Baslangic,Bitis")] JobExperience jobExperience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobExperience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobExperience);
        }

        // GET: Admin/JobExperiences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobExperience jobExperience = db.JobExperiences.Find(id);
            if (jobExperience == null)
            {
                return HttpNotFound();
            }
            return View(jobExperience);
        }

        // POST: Admin/JobExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobExperience jobExperience = db.JobExperiences.Find(id);
            db.JobExperiences.Remove(jobExperience);
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
