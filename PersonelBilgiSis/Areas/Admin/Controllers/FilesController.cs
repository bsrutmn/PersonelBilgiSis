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
    public class FilesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/Files
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.Files.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/Files/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Files files = db.Files.Find(id);
            if (files == null)
            {
                return HttpNotFound();
            }
            return View(files);
        }

        // GET: Admin/Files/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Files/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FileID,FileName,FilePath")] Files files)
        {
            if (ModelState.IsValid)
            {
                db.Files.Add(files);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(files);
        }

        // GET: Admin/Files/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Files files = db.Files.Find(id);
            if (files == null)
            {
                return HttpNotFound();
            }
            return View(files);
        }

        // POST: Admin/Files/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FileID,FileName,FilePath")] Files files)
        {
            if (ModelState.IsValid)
            {
                db.Entry(files).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(files);
        }

        // GET: Admin/Files/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Files files = db.Files.Find(id);
            if (files == null)
            {
                return HttpNotFound();
            }
            return View(files);
        }

        // POST: Admin/Files/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Files files = db.Files.Find(id);
            db.Files.Remove(files);
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
