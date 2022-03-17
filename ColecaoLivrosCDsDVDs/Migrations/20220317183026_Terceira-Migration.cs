using Microsoft.EntityFrameworkCore.Migrations;

namespace ColecaoLivrosCDsDVDs.Migrations
{
    public partial class TerceiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DVDs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "CDs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DVDs");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CDs");
        }
    }
}
