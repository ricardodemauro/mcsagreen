using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<Contato> Contatos { get; set; }

        public WebTodosDbContext(DbContextOptions<WebTodosDbContext> options)
        : base(options)
        {

        }
    }
}
