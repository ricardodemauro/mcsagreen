using Green.AlbumCopa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green.AlbumCopa.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Jogador> Jogador { get; set; }

        public AppDbContext()
            : base("DataConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>()
                .Property(x => x.Numero)
                .HasColumnName("NumeroDoJogador");

            modelBuilder.Entity<Jogador>()
                .Property(x => x.Altura)
                .HasMaxLength(6);


            modelBuilder.Entity<Jogador>()
                .Property(x => x.Id)
                .HasColumnName("jogardor_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Jogador>()
                .Property(x => x.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("nome")
                    .IsRequired();

            modelBuilder.Entity<Jogador>()
                .Property(x => x.Pais)
                .HasMaxLength(200);


            base.OnModelCreating(modelBuilder);
        }
    }
}
