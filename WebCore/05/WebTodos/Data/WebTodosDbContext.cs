using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTodos.Models;

namespace WebTodos.Data
{
    public class WebTodosDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=WebTodos;Integrated Security=True;Pooling=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(x => x.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Todo>()
                .Property(x => x.Descricao)
                .HasMaxLength(100)
                .IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
