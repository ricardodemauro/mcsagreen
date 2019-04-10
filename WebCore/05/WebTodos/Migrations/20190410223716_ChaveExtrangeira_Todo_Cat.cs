using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTodos.Migrations
{
    public partial class ChaveExtrangeira_Todo_Cat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Todos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Todos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_CategoriaId",
                table: "Todos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Categorias_CategoriaId",
                table: "Todos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Categorias_CategoriaId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_CategoriaId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Todos");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Todos",
                nullable: true);
        }
    }
}
