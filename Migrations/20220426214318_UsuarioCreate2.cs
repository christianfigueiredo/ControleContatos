using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleContatos.Migrations
{
    public partial class UsuarioCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
