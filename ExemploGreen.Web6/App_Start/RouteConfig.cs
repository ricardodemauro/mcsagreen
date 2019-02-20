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
                name: "MinhaRota",
                url: "ricardo/{id}/{lang}",
                defaults: new { controller = "Contato", action = "Detalhe" },
                constraints: new { id = "[0-9]+", lang = "[a-zA-Z]+" }
                );

            routes.MapRoute(
                name: "ContatoRoute",
                url: "contato/{id}/{name}",
                defaults: new { controller = "Contato", action = "Detalhe" },
                constraints: new { id = "[0-9]+", name = @"[\w-]+" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
