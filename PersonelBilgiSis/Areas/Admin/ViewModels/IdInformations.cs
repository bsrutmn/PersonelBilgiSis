using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class IdInformationsCreate
    {
        public int Id { get; set; }
        [Display(Name = "Ad Soyad")]
        public string NameSurname { get; set; }
        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }
        [Display(Name = "Unvan")]
        public string Degree { get; set; }
        [Display(Name = "Doğum Yeri")]
        public string Birthpalace { get; set; }
        [Display(Name = "TC")]
        public string TCKNO { get; set; }
        [Display(Name = "Sicil No")]
        public string RegistryNo { get; set; }
        [Display(Name = "Departman")]
        public virtual Department Department{ get; set; }
        [Display(Name = "Yabancı Dil")]
        public string ForeignLanguage { get; set; }
        [Display(Name = "Uzmanlık  ")]
        public string Professions { get; set; }
        [Display(Name = "İlgi Alanı")]
        public string Interests { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string TelephoneNumber { get; set; }
        
        public string Dahili { get; set; }
        [Display(Name = "Kurumsal VOIP")]
        public string KurumsalVoip { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        [Display(Name = "Diğer Email")]
        public string OtherEmail { get; set; }
        public virtual User User { get; set; }
        public List<IdInformationsCreate> IdInformation { get; set; }
    }


}