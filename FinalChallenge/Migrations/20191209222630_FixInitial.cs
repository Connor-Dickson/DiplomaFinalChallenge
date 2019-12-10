using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalChallenge.Migrations
{
    public partial class FixInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "amtPaid",
                table: "Game",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "payingMember",
                table: "Game",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amtPaid",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "payingMember",
                table: "Game");
        }
    }
}
