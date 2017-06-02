using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonelBilgiSis
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" }, new[] { "PersonelBilgiSis.Controllers" });
            routes.MapRoute("PersonelResult", "Personelgoster", new { controller = "PersonelResult", action = "Index" }, new[] { "PersonelBilgiSis.Controllers" });
            routes.MapRoute("Details", "Detail/{id}", new { controller = "Home", action = "Detail",id=UrlParameter.Optional}, new[] { "PersonelBilgiSis.Controllers" });
            routes.MapRoute("Detail", "KimlikBilgileri/{id}", new { controller = "Home", action = "KimlikBilgileri", id = UrlParameter.Optional }, new[] { "PersonelBilgiSis.Controllers" });

        }
    }
}
