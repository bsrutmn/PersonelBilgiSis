using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelInformationSystem.Areas.Admin.Models
{
    public class Duty
    {
        [Key]
        public string DutyId { get; set; }
        [Display(Name = "Görev")]
        public string DutyName { get; set; }
        public  virtual List<AcademicandAdministrativeDuties>AcedemicandAdministrativeDuties { get; set; }

    }
}