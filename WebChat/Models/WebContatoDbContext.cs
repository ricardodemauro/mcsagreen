using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChat.Models
{
    public class WebContatoDbContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public WebContatoDbContext(DbContextOptions<WebContatoDbContext> options)
            : base(options)
        {

        }
    }
}
