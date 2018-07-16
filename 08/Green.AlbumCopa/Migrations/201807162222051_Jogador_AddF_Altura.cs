namespace Green.AlbumCopa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Jogador_AddF_Altura : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Jogadors", name: "Numero", newName: "NumeroDoJogador");
            AddColumn("dbo.Jogadors", "Altura", c => c.String(maxLength: 6));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jogadors", "Altura");
            RenameColumn(table: "dbo.Jogadors", name: "NumeroDoJogador", newName: "Numero");
        }
    }
}
