using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Infraestrutura.Filters
{
    public class GreenLoggerAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string ip = filterContext.HttpContext.Request.Headers["HTTP_X_FORWARDED_FOR"];
            string controller = (string)filterContext.RouteData.Values["Controller"];
            string action = (string)filterContext.RouteData.Values["Action"];

            Trace.TraceInformation($"IP {ip} Ctrl {controller} Act {action}");
            Trace.Flush();
            base.OnActionExecuting(filterContext);
        }
    }
}