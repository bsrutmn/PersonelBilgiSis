using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelInformationSystem.Areas.Admin.Models
{
    public class AcademicandAdministrativeDuties
    {
        [Key]
        public int DutyId { get; set; }
        [Display(Name = "Site")]
        public string Sites { get; set; }
        
        public virtual Department BirimID { get; set; }
        public virtual Duty GorevID { get; set; }
        [Display(Name = "Başlangıç")]
        public string Start { get; set; }
        [Display(Name = "Bitiş")]
        public string Finish { get; set; }
        public string Telefon { get; set; }
        public string Dahili { get; set; }
        public virtual User KisiID { get; set; }

    }
}