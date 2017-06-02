using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelInformationSystem.Areas.Admin.Models
{
    public class JobExperience
    {
        [Key]
        public int JobID { get; set; }
        [Display(Name = "Kurum ")]
        public string Birim_Kurum { get; set; }
        [Display(Name = "Görev")]
        public string Gorev { get; set; }
        [Display(Name = "Başlangıç")]
        public string Baslangic { get; set; }
        [Display(Name = "Bitiş")]
        public string Bitis { get; set; }
        public virtual User KisiID { get; set; }

    }
}