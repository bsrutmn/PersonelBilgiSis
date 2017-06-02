using PersonelBilgiSis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelBilgiSis.Areas.Admin.ViewModels
{
    public class FilesCreate
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public virtual User KisiID { get; set; }
    }
}