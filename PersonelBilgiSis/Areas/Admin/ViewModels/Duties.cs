using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class DutiesCreate
    {
        public string DutyId { get; set; }
        public string DutyName { get; set; }
        public virtual List<AcademicandAdministrativeDuties> AcedemicandAdministrativeDuties { get; set; }
    }
}