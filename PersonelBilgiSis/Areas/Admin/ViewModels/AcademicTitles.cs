using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class AcademicTitlesCreate
    {
        public int AcademicId { get; set; }
        public string Unvan { get; set; }
        public string institution { get; set; }
        public int Year { get; set; }
        public virtual User KisiID { get; set; }
    }
}