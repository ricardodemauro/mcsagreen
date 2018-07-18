using Green.Alunos.Domain;
using Green.Alunos.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green.Alunos.Application
{
    public class AlunoApplication
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoApplication(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Task<List<Aluno>> ListaAlunos()
        {
            return _alunoRepositorio.GetAlunos();
        }

        public Task<Aluno> AdicionaAluno(Aluno aluno)
        {
            return _alunoRepositorio.AdicionarAluno(aluno);
        }
    }
}
