﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Infraestrutura.Filters
{
    public class FiltroDoLucas : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string lang = (filterContext.RequestContext.RouteData.Values["lang"] ?? "en-US").ToString();

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);

            if (filterContext.RouteData.Values.ContainsKey("ValorRANDOM") == false)
                filterContext.RouteData.Values.Add("ValorRANDOM", Guid.NewGuid().ToString());
            base.OnActionExecuting(filterContext);
        }
    }
}