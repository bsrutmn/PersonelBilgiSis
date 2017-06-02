using PersonelBilgiSis.Areas.Admin.Models;
using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class PublicationsCreate
    {
        public int PublicationId { get; set; }
        public virtual PublicationsCategories CategorieID { get; set; }
        public string PublicationTR { get; set; }
        public string PublicationEN { get; set; }
        public int Month { get; set; }
        public string Year { get; set; }
        public int Row { get; set; }
        public virtual User KisiID { get; set; }
    }
}