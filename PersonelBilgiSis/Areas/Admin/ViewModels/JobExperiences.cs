using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class JobExperiencesCreate
    {
        public int JobID { get; set; }
        public string Birim_Kurum { get; set; }
        public string Gorev { get; set; }
        public string Baslangic { get; set; }
        public string Bitis { get; set; }
        public virtual User KisiID { get; set; }
    }
}