using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green.Alunos.Domain.Repositorio
{
    public interface IAlunoRepositorio
    {
        Task<List<Aluno>> GetAlunos();

        Task<Aluno> AdicionarAluno(Aluno aluno);
    }
}
