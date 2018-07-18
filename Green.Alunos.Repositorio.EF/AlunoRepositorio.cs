using Green.Alunos.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Green.Alunos.Domain;
using System.Data.Entity;

namespace Green.Alunos.Repositorio.EF
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly ApplicationDbContext db;

        public AlunoRepositorio()
        {
            db = new ApplicationDbContext();
        }

        public async Task<Aluno> AdicionarAluno(Aluno aluno)
        {
            db.Aluno.Add(aluno);
            await db.SaveChangesAsync();
            return aluno;
        }

        public Task<List<Aluno>> GetAlunos()
        {
            return db.Aluno.ToListAsync();
        }
    }
}
