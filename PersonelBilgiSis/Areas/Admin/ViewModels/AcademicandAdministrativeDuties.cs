using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class AcademicandAdministrativeDutiesCreate
    {
        public int DutyId { get; set; }
        public string Sites { get; set; }
        public virtual Department BirimID { get; set; }
        public virtual Duty GorevID { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Telefon { get; set; }
        public string Dahili { get; set; }
        public virtual User KisiID { get; set; }
    }
}