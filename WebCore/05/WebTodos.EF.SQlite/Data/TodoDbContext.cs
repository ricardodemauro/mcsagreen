using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.EF.SQlite.Models;

namespace WebTodos.EF.SQlite.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Todo> Todos { get; set; }

        public TodoDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("WebTodos.db");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
