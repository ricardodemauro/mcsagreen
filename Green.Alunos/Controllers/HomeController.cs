﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Alunos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public string VariavelAmbiente()
        {
            return Environment.GetEnvironmentVariable("CONN_STR_ALUNOS");
        }

        [HttpPost]
        public ActionResult Contact(int f)
        {
            ViewBag.Message = "Your contact page.";

            //throw new Exception("some error");

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            //throw new Exception("some error");
            
            return View();
        }
    }
}