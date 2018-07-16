namespace Green.AlbumCopa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        jogardor_id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 200),
                        Pais = c.String(maxLength: 215),
                        Numero = c.Int(),
                    })
                .PrimaryKey(t => t.jogardor_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogadors");
        }
    }
}
