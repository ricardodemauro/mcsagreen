using Green.Alunos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green.Alunos.Repositorio.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }

        public ApplicationDbContext()
            : base("DbConnection2")
        {

        }
    }
}
