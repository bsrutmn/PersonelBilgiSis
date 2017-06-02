using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelInformationSystem.Areas.Admin.Models
{
    public class Files
    {
        [Key]
        public int FileID { get; set; }
        [Display(Name = "Dosya Adı")]
        public string FileName { get; set; }
        [Display(Name = "Dosya Yolu")]
        public string FilePath { get; set; }
        public virtual User KisiID { get; set; }
    }
}