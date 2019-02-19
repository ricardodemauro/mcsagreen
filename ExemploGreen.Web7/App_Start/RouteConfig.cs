using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExemploGreen.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "PhotoRoute",
              url: "contato/{id}",
              defaults: new { lang = "en-us", controller = "Contato", action = "Detalhe", id = UrlParameter.Optional },
              namespaces: new string[] { "Green.Ajax.Controllers" },
              constraints: new { id = "[0-9]+" }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Contato", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{lang}/{controller}/{action}/{id}",
                defaults: new { lang = "en-us", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
