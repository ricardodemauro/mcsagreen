namespace Green.AlbumCopa.Migrations
{
    using Green.AlbumCopa.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Green.AlbumCopa.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Green.AlbumCopa.Data.AppDbContext context)
        {
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
