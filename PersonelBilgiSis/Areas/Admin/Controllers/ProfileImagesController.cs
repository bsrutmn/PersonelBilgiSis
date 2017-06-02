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
    public class ProfileImagesController : Controller
    {
        private DB db = new DB();

        // GET: Admin/ProfileImages
        public ActionResult Index()
        {
            return View(db.ProfileImages.ToList());
        }

        // GET: Admin/ProfileImages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfileImage profileImage = db.ProfileImages.Find(id);
            if (profileImage == null)
            {
                return HttpNotFound();
            }
            return View(profileImage);
        }

        // GET: Admin/ProfileImages/Create
        public ActionResult Create()
        {
            var user = (User)Session["User"];
            var control = db.ProfileImages.FirstOrDefault(p => p.KisiID.UserID == user.UserID);
            if (control != null)
            {
                return View(new ProfileImagesCreate()
                {
                    ProfileImageID = control.ProfileImageID,
                    ImagePath = control.ImagePath
                });
            }
            else
            {
                return View(new ProfileImagesCreate());
            }
        }

        // POST: Admin/ProfileImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfileImagesCreate form)
        {
           
            var control = db.ProfileImages.FirstOrDefault(p => p.ProfileImageID == form.ProfileImageID);
            if (control == null)
            {
                control = new ProfileImage();
            }
            control.ProfileImageID = form.ProfileImageID;
            control.ImagePath = form.ImagePath;
            if (control.ProfileImageID==0)
            {
                db.ProfileImages.Add(control);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Admin/ProfileImages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfileImage profileImage = db.ProfileImages.Find(id);
            if (profileImage == null)
            {
                return HttpNotFound();
            }
            return View(profileImage);
        }

        // POST: Admin/ProfileImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProfileImageID,ImagePath")] ProfileImage profileImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profileImage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profileImage);
        }

        // GET: Admin/ProfileImages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfileImage profileImage = db.ProfileImages.Find(id);
            if (profileImage == null)
            {
                return HttpNotFound();
            }
            return View(profileImage);
        }

        // POST: Admin/ProfileImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfileImage profileImage = db.ProfileImages.Find(id);
            db.ProfileImages.Remove(profileImage);
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
