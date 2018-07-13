using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExemploGreen.Web.Infraestrutura.Filters
{
    public class AppErrorFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var routeData = filterContext.RouteData;
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("Controller: {0} Action: {1}", controllerName, actionName);
            Trace.TraceError("ARGH - ERROR LogFilter: -> " + message);

            Trace.TraceError(filterContext.Exception.Message);
            Trace.Flush();
        }
    }
}
