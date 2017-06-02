using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Models
{
    public class User
    {

        public int UserID { get; set; }
        [Required(ErrorMessage ="Lütfen emailinizi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        public string UserNameSurname { get; set; }
        public virtual Department Department {get; set;}
        public virtual List<EducationInfo> EducationInfo { get; set; }
       

    }
}