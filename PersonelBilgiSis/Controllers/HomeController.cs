using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelBilgiSis.ViewModel;
using PersonelBilgiSis.Models;
using System.Data;

using PersonnelInformationSystem.Areas.Admin.Models;
using System.Net;
using Microsoft.AspNet.Identity;

namespace PersonelBilgiSis.Controllers
{
    public class HomeController : Controller
    {
        DB db = new DB();
        // GET: Home
        public ActionResult Index()
        {
            return View(new HomeIndex());
        }

        [HttpPost]
        public ActionResult Index(HomeIndex formData)
        {
            if (formData.PersonelNameFilter == null)
            {
                formData.PersonelNameFilter = "";
            }
            if (formData.DepartmentFilter == null)
            {
                formData.DepartmentFilter = "";
            }
            formData.Users = db.Users.Where(p => p.UserNameSurname.Contains(formData.PersonelNameFilter) && p.Department.DepartmentName.Contains(formData.DepartmentFilter)).ToList();

            return View(formData);
        }
        public ActionResult Detail(int id)
        {

            var user = db.Users.FirstOrDefault(p => p.UserID == id);
            var idInformation = db.IdInformations.FirstOrDefault(p => p.KisiID.UserID == user.UserID);
            var academicsunvan = db.AcademicTitle.Where(p => p.KisiID.UserID == user.UserID).ToList();
            var AcademicandAdministrativeDuties=db.AcademicandAdministrativeDuties.Where(p => p.KisiID.UserID == user.UserID).ToList();
            var educationinfo = db.EducationInfos.Where(p => p.KisiID.UserID == user.UserID).ToList();
            var yayin=db.Publications.Where(p => p.KisiID.UserID == user.UserID).ToList();
            var ders=db.GivenLessons.Where(p => p.KisiID.UserID == user.UserID).ToList();
            var duyuru=db.Notices.Where(p => p.KisiID.UserID == user.UserID).ToList();

            
            if (idInformation == null) idInformation = new IdInformation();
            if (academicsunvan == null) academicsunvan = new List<Areas.Admin.Models.AcademicTitle>();
            if (AcademicandAdministrativeDuties == null) AcademicandAdministrativeDuties = new List<AcademicandAdministrativeDuties>();
            if (educationinfo == null) educationinfo = new List<EducationInfo>();
            if (yayin == null) yayin = new List<Areas.Admin.Models.Publications>();
            if (ders == null) ders = new List<Areas.Admin.Models.GivenLessons>();
            if (duyuru == null) duyuru = new List<Notices>();


            var data = new HomeDetail() {
                AcademicTitles = academicsunvan,
                IdInformation = idInformation,
                GivenLessons = ders,
                Notices = duyuru,
                Publications = yayin,
                EducationInfoes = educationinfo,
                AcademianAndAdministrativeDuties = AcademicandAdministrativeDuties
            };
            return View(data);
        }
      
    }
}
