namespace Green.Album.Autenticado.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Field_NomeCompleto_Entity_ApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NomeCompleto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NomeCompleto");
        }
    }
}
