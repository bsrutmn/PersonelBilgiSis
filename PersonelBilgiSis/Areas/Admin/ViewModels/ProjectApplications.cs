using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class ProjectApplicationsCreate
    {
        public int ProjectId { get; set; }
        public string ProjectState { get; set; }
        public string ProjectType { get; set; }
        public string ApplicantInstitution { get; set; }
        public string ProjectName { get; set; }
        public string Durumu { get; set; }
        public virtual User KisiID { get; set; }
    }
}