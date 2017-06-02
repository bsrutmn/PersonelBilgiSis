using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class BiographiesCreate
    {
        public int BioId { get; set; }
        public string BiographyContent { get; set; }
        public virtual User KisiID { get; set; }
    }
}