using Green.Alunos.Application;
using Green.Alunos.Repositorio.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Green.Alunos.Infraestrutura
{
    public static class IoC
    {
        public static AlunoApplication GetAlunoApp()
        {
            var repo = new AlunoRepositorio();
            return new AlunoApplication(repo);
        }
    }
}