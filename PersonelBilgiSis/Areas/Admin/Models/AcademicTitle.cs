using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class AcademicTitle
    {   [Key]
        public int AcademicId { get; set; }

        public string Unvan { get; set; }
        [Display(Name = "Kurum")]
        public string institution { get; set; }
        [Display(Name = "Yıl")]
        public int Year { get; set; }
        public virtual User KisiID { get; set; }
    }
}