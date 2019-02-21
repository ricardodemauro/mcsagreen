using Green.Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Ajax.Controllers
{
    public class HomeController : Controller
    {
        private static List<Aluno> alunos = new List<Aluno>();

        static HomeController()
        {
            alunos.Add(new Aluno
            {
                Id = 1,
                Nome = "Iago"
            });
            alunos.Add(new Aluno
            {
                Id = 2,
                Nome = "Luiz"
            });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult MyPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MyPartialPost()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult CreateAlunoPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PostAluno(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                alunos.Add(aluno);
                return PartialView("CreateAlunoPartial");
            }
            else
            {
                return PartialView("CreateAlunoPartial", aluno);
            }
        }

        public PartialViewResult GetAlunos()
        {
            return PartialView(alunos);
        }
    }
}