using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        DB db = new DB();
        // GET: Admin/Home
        public ActionResult Index()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AcademicandAdministrativeDuties()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Department()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Duty()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Files()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IdInformation()
        {

            return View();
        }
        [HttpGet]
        public ActionResult KimlikBilgileriEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult KimlikBilgileriEkle(User kisi)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(kisi);
                db.SaveChanges();

            }

            return View();
        }
        public ActionResult KimlikBilgileriSil(int id)
        {
            return View();
        }
        public ActionResult KimlikBilgileriGuncelle(int id)
        {
            return View();
        }
        public ActionResult KimlikBilgileriListele(int id)
        {

            return View();
        }
        public ActionResult ProfilFotoEkle()
        {

            return View();
        }
        public ActionResult ProfilFotoSil(int id)
        {
            return View();
        }
        public ActionResult ProfilFotoGuncelle(int id)
        {
            return View();
        }
        public ActionResult ProfilFotoListele(int id)
        {
            return View();
        }
        public ActionResult BiyografiEkle()
        {
            return View();
        }
        public ActionResult BiyografiSil(int id)
        {
            return View();
        }
        public ActionResult BiyografiGuncelle(int id)
        {
            return View();
        }
        public ActionResult BiyografiListele(int id)
        {
            return View();
        }
        public ActionResult EgitimDurumuEkle()
        {
            return View();
        }
        public ActionResult EgitimDurumuSil(int id)
        {
            return View();
        }
        public ActionResult EgitimDurumuGuncelle(int id)
        {
            return View();
        }
        public ActionResult EgitimDurumuListele(int id)
        {
            return View();
        }
        public ActionResult AkademikGorevEkle()
        {
            return View();
        }
        public ActionResult AkademikGorevSil(int id)
        {
            return View();
        }
        public ActionResult AkademikGorevGuncelle(int id)
        {
            return View();
        }
        public ActionResult AkademikGorevListele(int id)
        {
            return View();
        }
        public ActionResult IsTecrubesiEkle()
        {
            return View();
        }
        public ActionResult IsTecrubesiSil(int id)
        {
            return View();
        }
        public ActionResult IsTecrubesiGuncelle(int id)
        {
            return View();
        }
        public ActionResult IsTecrubesiListele(int id)
        {
            return View();
        }
        public ActionResult YayinEkle()
        {
            return View();
        }
        public ActionResult YayinSil(int id)
        {
            return View();
        }
        public ActionResult YayinGuncelle(int id)
        {
            return View();
        }
        public ActionResult YayinListele(int id)
        {
            return View();
        }
        public ActionResult VerilenDersEkle()
        {
            return View();
        }
        public ActionResult VerilenDersSil(int id)
        {
            return View();
        }
        public ActionResult VerilenDersGuncelle(int id)
        {
            return View();
        }
        public ActionResult VerilenDersListele(int id)
        {
            return View();
        }
        public ActionResult ProjesiUygulamasiEkle()
        {
            return View();
        }
        public ActionResult ProjeUygulamasiSil(int id)
        {
            return View();
        }
        public ActionResult ProjeUygulamasiGuncelle(int id)
        {
            return View();
        }
        public ActionResult ProjeUygulamasiListele(int id)
        {
            return View();
        }
        public ActionResult DuyuruEkle()
        {
            return View();
        }
        public ActionResult DuyuruSil(int id)
        {
            return View();
        }
        public ActionResult DuyuruGuncelle(int id)
        {
            return View();
        }
        public ActionResult DuyuruListele(int id)
        {
            return View();
        }
      
    }
}