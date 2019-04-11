using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGreetingBook.Models;

namespace WebGreetingBook.Data
{
    public class GreentingDbContext : DbContext
    {
        public DbSet<Greeting> Greetings { get; set; }

        public GreentingDbContext(DbContextOptions<GreentingDbContext> options)
            : base(options)
        {

        }
    }
}
