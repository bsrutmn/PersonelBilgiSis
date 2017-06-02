using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class GivenLessonsCreate
    {
        public int LessonId { get; set; }
        public string Sites { get; set; }
        public string LessonName { get; set; }
        public virtual User KisiID { get; set; }
    }
}