using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class Biography
    {   [Key]
        public int BioId { get; set; }
        [Display(Name = "Biyografi")]
        public string BiographyContent { get; set; }
        public virtual User KisiID { get; set; }

    }
}