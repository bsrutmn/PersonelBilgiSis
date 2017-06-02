using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelBilgiSis.Areas.Admin.Controllers
{
    public class PageController : Controller
    {
        // GET: Admin/Page
        public ActionResult Index()
        {
            return View();
        }
    }
}