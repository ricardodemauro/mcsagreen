using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExemploGreen.Web.Infraestrutura.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine($"Passing on {nameof(OnActionExecuting)}");

            string controller = filterContext.RouteData.Values["controller"] as string;
            string action = filterContext.RouteData.Values["action"] as string;

            string languageName = System.Threading.Thread.CurrentThread.CurrentCulture.DisplayName;

            //filterContext.RequestContext.HttpContext.Request.Cookies["lang"].Value;

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine($"Passing on {nameof(OnActionExecuted)}");
            base.OnActionExecuted(filterContext);
        }
    }
}
