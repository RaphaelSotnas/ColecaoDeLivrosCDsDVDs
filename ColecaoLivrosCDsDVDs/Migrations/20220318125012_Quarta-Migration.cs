using Microsoft.EntityFrameworkCore.Migrations;

namespace ColecaoLivrosCDsDVDs.Migrations
{
    public partial class QuartaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Pessoas");
        }
    }
}
