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
    public class ProjectApplicationsController : Controller
    {
        private DB db = new DB();

        // GET: Admin/ProjectApplications
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.ProjectApplication.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }
        // GET: Admin/ProjectApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectApplication projectApplication = db.ProjectApplication.Find(id);
            if (projectApplication == null)
            {
                return HttpNotFound();
            }
            return View(projectApplication);
        }

        // GET: Admin/ProjectApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProjectApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ProjectState,ProjectType,ApplicantInstitution,ProjectName,Durumu")] ProjectApplication projectApplication)
        {
            if (ModelState.IsValid)
            {
                db.ProjectApplication.Add(projectApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectApplication);
        }

        // GET: Admin/ProjectApplications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectApplication projectApplication = db.ProjectApplication.Find(id);
            if (projectApplication == null)
            {
                return HttpNotFound();
            }
            return View(projectApplication);
        }

        // POST: Admin/ProjectApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ProjectState,ProjectType,ApplicantInstitution,ProjectName,Durumu")] ProjectApplication projectApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectApplication);
        }

        // GET: Admin/ProjectApplications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectApplication projectApplication = db.ProjectApplication.Find(id);
            if (projectApplication == null)
            {
                return HttpNotFound();
            }
            return View(projectApplication);
        }

        // POST: Admin/ProjectApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectApplication projectApplication = db.ProjectApplication.Find(id);
            db.ProjectApplication.Remove(projectApplication);
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
