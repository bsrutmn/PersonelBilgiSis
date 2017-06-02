using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class UsersCreate
    {
        [Display(Name = "ID")]
        public int UserID { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        public string PasswordHash { get; set; }
        [Display(Name = "Ad Soyad")]
        public string UserNameSurname { get; set; }
        [Display(Name = "Departman")]
        public virtual Department Department { get; set; }
        [Display(Name = "Eğitim Bilgileri")]
        public virtual List<EducationInfo> EducationInfo { get; set; }
    }
}