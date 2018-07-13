using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExemploGreen.Web.Infraestrutura.Filters
{
    public sealed class AuditFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log(nameof(OnActionExecuting), filterContext.RouteData);
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log(nameof(OnActionExecuted), filterContext.RouteData);
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log(nameof(OnResultExecuted), filterContext.RouteData);
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log(nameof(OnResultExecuting), filterContext.RouteData);
            base.OnResultExecuting(filterContext);
        }

        public static void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("Controller: {0} Action: {1} MethodName: {2}", controllerName, actionName, methodName);

            Trace.TraceInformation("UHUUU - LogFilter: -> " + message);
            Trace.Flush();
        }
    }
}
