using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkersApp.Data.Migrations
{
    public partial class AddedEmails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Worker",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Worker");
        }
    }
}
