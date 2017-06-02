using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonnelInformationSystem.Areas.Admin.Models
{
    public class Notices
    {
        [Key]
        public int NoticeId { get; set; }
        [Display(Name = "Site")]
        public string  Sites { get; set; }
        [Display(Name = "Duyuru")]
        public string NoticeTitle{ get; set; }
        public virtual User KisiID { get; set; }

    }
}