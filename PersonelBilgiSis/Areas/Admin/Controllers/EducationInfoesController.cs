using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonelBilgiSis;
using PersonelBilgiSis.Models;
using PersonelBilgiSis.Areas.Admin.ViewModels;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class EducationInfoesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/EducationInfoes
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.EducationInfos.Where(p=>p.KisiID.UserID==user.UserID).ToList());
        }

        // GET: Admin/EducationInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationInfo educationInfo = db.EducationInfos.Find(id);
            if (educationInfo == null)
            {
                return HttpNotFound();
            }
            return View(educationInfo);
        }

        // GET: Admin/EducationInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/EducationInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EducationInfoID,OgrenimSeviyesi,SchoolName,MezuniyetYili,Tez,TezUrl")] EducationInfo educationInfo)
        {
            if (ModelState.IsValid)
            {
                db.EducationInfos.Add(educationInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(educationInfo);
        }


        // GET: Admin/EducationInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationInfo educationInfo = db.EducationInfos.Find(id);
            if (educationInfo == null)
            {
                return HttpNotFound();
            }
            return View(educationInfo);
        }

        // POST: Admin/EducationInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EducationInfoID,OgrenimSeviyesi,SchoolName,MezuniyetYili,Tez,TezUrl")] EducationInfo educationInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(educationInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(educationInfo);
        }

        // GET: Admin/EducationInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EducationInfo educationInfo = db.EducationInfos.Find(id);
            if (educationInfo == null)
            {
                return HttpNotFound();
            }
            return View(educationInfo);
        }

        // POST: Admin/EducationInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EducationInfo educationInfo = db.EducationInfos.Find(id);
            db.EducationInfos.Remove(educationInfo);
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
