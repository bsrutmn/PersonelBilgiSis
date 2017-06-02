using PersonelBilgiSis.Areas.Admin.Models;
using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.ViewModel
{
    public class HomeDetail
    {
        public virtual User User { get; set; }
        public virtual IdInformation IdInformation { get; set; }
        public virtual  List<GivenLessons> GivenLessons { get; set; }
        public virtual List<AcademicTitle> AcademicTitles { get; set; }
        public virtual List<AcademicandAdministrativeDuties> AcademianAndAdministrativeDuties { get; set; }
        public virtual List<EducationInfo> EducationInfoes { get; set; }
        public virtual List<Publications> Publications { get; set; }
        public virtual List<Notices> Notices { get; set; }
        public virtual List<Duty> Duties { get; set; }
        public virtual List<Department> Departments { get; set; }
    }
}