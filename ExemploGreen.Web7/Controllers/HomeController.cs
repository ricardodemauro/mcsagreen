﻿using ExemploGreen.Web.Infraestrutura.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Language = "algum valor";

            //ViewData["Lang"] = "algum outro valor";

            //string myLang = ViewData["Language"] as string;
            //ViewData["VBLanguage"] = myLang;

            ViewBag.Info = TempData.ContainsKey("Info") ? TempData["Info"] : "nenhuma info";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [LanguageFilterAttribute]
        public string RotaLucas()
        {
            if (RouteData.Values.ContainsKey("ValorRANDOM"))
            {
                return RouteData.Values["ValorRANDOM"].ToString();
            }
            else
            {
                return "Ops nao tem";
            }
        }
    }
}