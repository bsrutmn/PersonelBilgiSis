using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonelBilgiSis.Models;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace PersonelBilgiSis.ViewModel
{
    public class HomeIndex
    {
        [Display(Name = "PERSONEL: ")]
        public string PersonelNameFilter{get; set;}
        [Display(Name = "BİRİM: ")]
        public string DepartmentFilter { get; set; }
        public List<User> Users { get; set; }
    }

}