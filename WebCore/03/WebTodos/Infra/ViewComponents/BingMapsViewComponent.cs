using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTodos.Infra.Models;

namespace WebTodos.Infra.ViewComponents
{
    public class BingMapsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(decimal? latitude,
            decimal? longitude)
        {
            if (latitude.HasValue && longitude.HasValue)
            {
                var model = new Location(longitude.Value,
                    latitude.Value);

                string bingUrl = $"https://www.bing.com/maps/embed?h=400&w=500&cp={model.Latitude}~{model.Longitude}lvl=13&typ=d&sty=r&src=SHELL&FORM=MBEDV8";
                model.UrlMaps = bingUrl;
                return View(model);
            }
            else
            {
                return Content("Argumentos faltando");
            }
        }
    }
}
