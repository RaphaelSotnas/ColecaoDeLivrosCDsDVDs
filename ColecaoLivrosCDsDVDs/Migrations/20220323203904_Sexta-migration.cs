using Microsoft.EntityFrameworkCore.Migrations;

namespace ColecaoLivrosCDsDVDs.Migrations
{
    public partial class Sextamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCd",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDvd",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdLivro",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCd",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdDvd",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdLivro",
                table: "Usuarios");
        }
    }
}
