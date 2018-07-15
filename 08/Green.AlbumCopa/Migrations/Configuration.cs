namespace Green.AlbumCopa.Migrations
{
    using Green.AlbumCopa.Data;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Green.AlbumCopa.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Green.AlbumCopa.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            foreach (var jogador in AlbumDataHelper.GetJogadores())
            {
                context.Jogador.Add(new Models.Jogador
                {
                    Nome = jogador["FIFA NAME"],
                    Numero = int.Parse(jogador["NUMERO"]),
                    Pais = jogador["SELECAO"]
                });
            }
            context.SaveChanges();
        }


    }
}
