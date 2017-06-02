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
    public class AcademicandAdministrativeDutiesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/AcademicandAdministrativeDuties
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.AcademicandAdministrativeDuties.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/AcademicandAdministrativeDuties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcademicandAdministrativeDuties academicandAdministrativeDuties = db.AcademicandAdministrativeDuties.Find(id);
            if (academicandAdministrativeDuties == null)
            {
                return HttpNotFound();
            }
            return View(academicandAdministrativeDuties);
        }

        // GET: Admin/AcademicandAdministrativeDuties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AcademicandAdministrativeDuties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DutyId,Sites,Start,Finish,Telefon,Dahili")] AcademicandAdministrativeDuties academicandAdministrativeDuties)
        {
            if (ModelState.IsValid)
            {
                db.AcademicandAdministrativeDuties.Add(academicandAdministrativeDuties);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(academicandAdministrativeDuties);
        }

        // GET: Admin/AcademicandAdministrativeDuties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcademicandAdministrativeDuties academicandAdministrativeDuties = db.AcademicandAdministrativeDuties.Find(id);
            if (academicandAdministrativeDuties == null)
            {
                return HttpNotFound();
            }
            return View(academicandAdministrativeDuties);
        }

        // POST: Admin/AcademicandAdministrativeDuties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DutyId,Sites,Start,Finish,Telefon,Dahili")] AcademicandAdministrativeDuties academicandAdministrativeDuties)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academicandAdministrativeDuties).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(academicandAdministrativeDuties);
        }

        // GET: Admin/AcademicandAdministrativeDuties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcademicandAdministrativeDuties academicandAdministrativeDuties = db.AcademicandAdministrativeDuties.Find(id);
            if (academicandAdministrativeDuties == null)
            {
                return HttpNotFound();
            }
            return View(academicandAdministrativeDuties);
        }

        // POST: Admin/AcademicandAdministrativeDuties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AcademicandAdministrativeDuties academicandAdministrativeDuties = db.AcademicandAdministrativeDuties.Find(id);
            db.AcademicandAdministrativeDuties.Remove(academicandAdministrativeDuties);
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
