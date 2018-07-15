namespace Green.AlbumCopa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove_Field_DataCriacao_Jogador : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Jogadors", "DataCriacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jogadors", "DataCriacao", c => c.DateTime());
        }
    }
}
