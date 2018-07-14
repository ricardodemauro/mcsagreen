using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public AppDbContext() 
            : base("GreenDb")
        {
        }
    }
}