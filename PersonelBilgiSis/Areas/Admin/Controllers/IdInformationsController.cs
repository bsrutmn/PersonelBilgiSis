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
using PersonelBilgiSis.Areas.Admin.ViewModels;
using PersonelBilgiSis.Models;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class IdInformationsController : Controller
    {
        private DB db = new DB();

        // GET: Admin/IdInformations
        public ActionResult Index()
        {
            return View(db.IdInformations.ToList());
        }

        // GET: Admin/IdInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdInformation idInformation = db.IdInformations.Find(id);
            if (idInformation == null)
            {
                return HttpNotFound();
            }
            return View(idInformation);
        }

        // GET: Admin/IdInformations/Create
        public ActionResult Create()
        {
            var user = (User)Session["User"];
            var control = db.IdInformations.FirstOrDefault(p => p.KisiID.UserID == user.UserID);

            if (control != null)
            {
                return View(new IdInformationsCreate()
                {
                    Id = control.Id,
                    NameSurname = control.NameSurname,
                    Gender = control.Gender,
                    Degree = control.Degree,
                    Birthpalace = control.Birthpalace,
                    TCKNO = control.TCKNO,
                    RegistryNo = control.RegistryNo,
                    ForeignLanguage = control.ForeignLanguage,
                    Professions = control.Professions,
                    Interests = control.Interests,
                    TelephoneNumber = control.TelephoneNumber,
                    Dahili = control.Dahili,
                    KurumsalVoip = control.KurumsalVoip,
                    GSM = control.GSM,
                    Email = control.Email,
                    OtherEmail = control.OtherEmail,
                    Department = control.Unit

                });
            }
            else
            {
                return View(new IdInformationsCreate());
            }
        }

        // POST: Admin/IdInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IdInformationsCreate form)
        {
            var control = db.IdInformations.FirstOrDefault(p => p.Id == form.Id);
            if (control == null)
            {
                control = new IdInformation();

            }
            control.NameSurname = form.NameSurname;
            control.Gender = form.Gender;
            control.Degree = form.Degree;
            control.Birthpalace = form.Birthpalace;
            control.TCKNO = form.TCKNO;
            control.RegistryNo = form.RegistryNo;
            control.ForeignLanguage = form.ForeignLanguage;
            control.Professions = form.Professions;
            control.Interests = form.Interests;
            control.TelephoneNumber = form.TelephoneNumber;
            control.Dahili = form.Dahili;
            control.KurumsalVoip = form.KurumsalVoip;
            control.GSM = form.GSM;
            control.Email = form.Email;
            control.OtherEmail = form.OtherEmail;
            control.Unit = form.Department;


            
                if (control.Id==0)
                {
                    db.IdInformations.Add(control);
                }
                
                db.SaveChanges();
                return RedirectToAction("Index");
            
            //else
            //{
            //    return View(form);
            //}
        }

        // GET: Admin/IdInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdInformation idInformation = db.IdInformations.Find(id);
            if (idInformation == null)
            {
                return HttpNotFound();
            }
            return View(idInformation);
        }

        // POST: Admin/IdInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameSurname,Gender,Degree,Birthpalace,TCKNO,RegistryNo,ForeignLanguage,Professions,Interests,TelephoneNumber,Dahili,KurumsalVoip,GSM,Email,OtherEmail")] IdInformation idInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(idInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(idInformation);
        }

        // GET: Admin/IdInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdInformation idInformation = db.IdInformations.Find(id);
            if (idInformation == null)
            {
                return HttpNotFound();
            }
            return View(idInformation);
        }

        // POST: Admin/IdInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IdInformation idInformation = db.IdInformations.Find(id);
            db.IdInformations.Remove(idInformation);
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
