﻿using ExemploGreen.Web.Data;
using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IDataSource<Contato> dataSource;

        public ContatoController()
            : this(ContatoDataSource.GetInstance())
        {

        }

        public ContatoController(IDataSource<Contato> dataSource)
        {
            this.dataSource = dataSource;
        }

        // GET: Contato
        public ActionResult Index()
        {
            ViewBag.Title = "Meu titulo lega";
            ViewBag.H1 = "Meu h1 maneiro";
            ViewBag.Idade = 18;
            ViewBag.Select = new Contato()
            {
                Id = 10,
                Nome = "Vindo do viewbag"
            };

            ViewBag._keke = "ekeke";


            ViewData["Title"] = "neoenoenoe";

            return View(dataSource.Get());
        }

        public ActionResult Detalhe(int id)
        {
            ViewBag.linguaDoUsuairo = ControllerContext.RouteData.Values["lang"] as string;

            Contato model = dataSource.Get(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Contato model = dataSource.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(int id, Contato model)
        {
            dataSource.Edit(model);
            return RedirectToAction("Index");
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Contato model)
        {
            if (!ModelState.IsValid)
                return View(model);

            dataSource.Add(model);
            return RedirectToAction("Index");
        }

    }
}