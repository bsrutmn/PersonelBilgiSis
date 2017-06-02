using PersonelBilgiSis.Models;
using PersonnelInformationSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.Models
{
    public class GivenLessons
    {    [Key]
        public int LessonId { get; set; }
        [Display(Name = "Site")]
        public string Sites { get; set; }
        [Display(Name = "Ders Adı")]
        public string LessonName { get; set; }

        public virtual User KisiID { get; set; }
    }
}