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
    public class PublicationsController : Controller
    {
        private DB db = new DB();

        // GET: Admin/Publications
        public ActionResult Index()
        {
            var user = (User)Session["user"];
            return View(db.Publications.Where(p => p.KisiID.UserID == user.UserID).ToList());
        }

        // GET: Admin/Publications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publications publications = db.Publications.Find(id);
            if (publications == null)
            {
                return HttpNotFound();
            }
            return View(publications);
        }

        // GET: Admin/Publications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Publications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PublicationId,PublicationTR,PublicationEN,Month,Year,Row")] Publications publications)
        {
            if (ModelState.IsValid)
            {
                db.Publications.Add(publications);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publications);
        }

        // GET: Admin/Publications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publications publications = db.Publications.Find(id);
            if (publications == null)
            {
                return HttpNotFound();
            }
            return View(publications);
        }

        // POST: Admin/Publications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PublicationId,PublicationTR,PublicationEN,Month,Year,Row")] Publications publications)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publications).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publications);
        }

        // GET: Admin/Publications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publications publications = db.Publications.Find(id);
            if (publications == null)
            {
                return HttpNotFound();
            }
            return View(publications);
        }

        // POST: Admin/Publications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Publications publications = db.Publications.Find(id);
            db.Publications.Remove(publications);
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
