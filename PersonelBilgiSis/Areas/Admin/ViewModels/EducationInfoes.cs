using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class EducationInfoesCreate { 


       
        public int EducationInfoID { get; set; }
        public string OgrenimSeviyesi { get; set; }
        public string SchoolName { get; set; }
        public int MezuniyetYili { get; set; }
        public string Tez { get; set; }
        public string TezUrl { get; set; }
        public virtual User KisiID { get; set; }
       
    }
}