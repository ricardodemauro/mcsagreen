using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Infraestrutura.Filters
{
    public class FiltroDoLucas : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.RouteData.Values.Add("ValorRANDOM", Guid.NewGuid().ToString());
            base.OnActionExecuting(filterContext);
        }
    }
}