namespace Green.AlbumCopa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Jogador : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        jogardor_id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 200),
                        Pais = c.String(maxLength: 200),
                        Numero = c.Int(),
                        DataCriacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.jogardor_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogadors");
        }
    }
}
