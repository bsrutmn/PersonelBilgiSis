using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class PublicationsCategories
    {
        [Key]
        [Display(Name = "Kategori ID")]
        public int CategoriID { get; set; }
        public string YayinKategorileriIsmi { get; set; }
    }
}