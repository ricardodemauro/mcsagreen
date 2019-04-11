using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class LogActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string controllerName = context.ActionDescriptor.RouteValues["Controller"];
            Debug.WriteLine($"{controllerName} - Passando por aqui - OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Passou por aqui - OnActionExecuting");
        }
    }
}
