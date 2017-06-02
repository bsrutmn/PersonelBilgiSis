using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class ProfileImagesCreate
    {
        public int ProfileImageID { get; set; }
        public string ImagePath { get; set; }
        public virtual User KisiID { get; set; }
    }
}