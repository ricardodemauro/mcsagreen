using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Green.Ajax
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "PhotoRoute2",
                url: "contato/detalhe/{id}",
                defaults: new { controller = "Cliente", action = "Details", id = UrlParameter.Optional },
                namespaces: new string[] { "Green.Ajax.Controllers" },
                constraints: new { id = "[0-9]+" }
            );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Green.Ajax.Controllers" }
            );

            routes.MapRoute(
              name: "PhotoRoute",
              url: "contato/{id}",
              defaults: new { controller = "Contato", action = "Detalhe", id = UrlParameter.Optional },
              namespaces: new string[] { "Green.Ajax.Controllers" },
              constraints: new { id = "[0-9]+" }
          );
        }
    }
}
