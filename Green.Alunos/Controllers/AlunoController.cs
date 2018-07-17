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

namespace Green.Alunos.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ApplicationDbContext db = ApplicationDbContext.Create();

        public async Task<ActionResult> Index()
        {
            List<Aluno> alunos = await db.Aluno.ToListAsync();
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
                db.Aluno.Add(new Aluno { Nome = alunoVm.Nome });
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(alunoVm);
        }
    }
}