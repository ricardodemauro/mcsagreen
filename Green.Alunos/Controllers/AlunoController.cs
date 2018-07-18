using Green.Alunos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Green.Alunos.ViewModels;
using Green.Alunos.Domain;
using Green.Alunos.Application;
using Green.Alunos.Infraestrutura;

namespace Green.Alunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoApplication _application = IoC.GetAlunoApp();

        public async Task<ActionResult> Index()
        {
            List<Aluno> alunos = await _application.ListaAlunos();
            return View(alunos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(NovoAlunoViewModel alunoVm)
        {
            if (ModelState.IsValid)
            {
                await _application.AdicionaAluno(new Aluno { Nome = alunoVm.Nome });
                return RedirectToAction("Index");
            }
            return View(alunoVm);
        }
    }
}