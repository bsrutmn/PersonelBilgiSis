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
using PersonelBilgiSis.Areas.Admin.ViewModels;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class BiographiesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/Biographies
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.Biography.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/Biographies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Biography biography = db.Biography.Find(id);
            if (biography == null)
            {
                return HttpNotFound();
            }
            return View(biography);
        }

        // GET: Admin/Biographies/Create
        public ActionResult Create()
        {
            var user = (User)Session["User"];
            var control = db.Biography.FirstOrDefault(p => p.KisiID.UserID == user.UserID);
            if (control != null)
            {
                return View(new BiographiesCreate()
                {
                    BioId = control.BioId,
                    BiographyContent = control.BiographyContent
                });
            }
            else
            {
                 return View(new BiographiesCreate());
            }
            
           
        }

        // POST: Admin/Biographies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( BiographiesCreate form)
        {
            var control = db.Biography.FirstOrDefault(p => p.BioId == form.BioId);
            if (control==null)
            {
                control = new Biography();

            }

            control.BioId = form.BioId;
            control.BiographyContent = form.BiographyContent;
            if (control.BioId==0)
            {
                db.Biography.Add(control);
              
               
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Admin/Biographies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Biography biography = db.Biography.Find(id);
            if (biography == null)
            {
                return HttpNotFound();
            }
            return View(biography);
        }

        // POST: Admin/Biographies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BioId,BiographyContent")] Biography biography)
        {
            if (ModelState.IsValid)
            {
                db.Entry(biography).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(biography);
        }

        // GET: Admin/Biographies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Biography biography = db.Biography.Find(id);
            if (biography == null)
            {
                return HttpNotFound();
            }
            return View(biography);
        }

        // POST: Admin/Biographies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Biography biography = db.Biography.Find(id);
            db.Biography.Remove(biography);
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
