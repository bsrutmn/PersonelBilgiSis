using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class ProjectApplication
    {  [Key]
        public int ProjectId { get; set; }
        [Display(Name = "Proje Durumu")]
        public string ProjectState { get; set; }
        [Display(Name = "Proje Çeşiti")]
        public string ProjectType { get; set; }
        [Display(Name = "Başvurulan Kurum")]
        public string ApplicantInstitution { get; set; }
        [Display(Name = "Proje Adı")]
        public string ProjectName { get; set; }
        public string Durumu { get; set; }
        public virtual User KisiID { get; set; }

    }
}