using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class ProfileImage
    {
        [Key]
       
        public int ProfileImageID { get; set; }
        [Display(Name = "Fotoğraf Yolu")]
        public string ImagePath { get; set; }
        public virtual User KisiID { get; set; }
    }
}