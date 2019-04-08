using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Infra.Models;

namespace WebTodos.Infra.ViewComponents
{
    [ViewComponent(Name = "DisplayMap")]
    public class DisplayMapViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(decimal? longitude, decimal? latitude)
        {
            if (longitude.HasValue && latitude.HasValue)
            {
                Location location = new Location(longitude.Value, latitude.Value);
                return View(location);
            }
            else
            {
                return Content(string.Empty);
            }
        }
    }
}
