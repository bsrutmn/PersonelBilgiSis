using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class Publications
    {
        [Key]
        public int PublicationId { get; set; }
        public virtual PublicationsCategories CategorieID { get; set; }
        [Display(Name = "Yayın TR")]
        public string PublicationTR { get; set; }
        [Display(Name = "Yayın EN")]
        public string PublicationEN { get; set; }
        [Display(Name = "Ay")]
        public int Month { get; set; }
        [Display(Name = "Yıl")]
        public string Year { get; set; }
        [Display(Name = "Satır")]
        public int Row { get; set; }
        public virtual User KisiID { get; set; }
    }
}