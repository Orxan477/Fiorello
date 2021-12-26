using Microsoft.EntityFrameworkCore.Migrations;

namespace FiorellaAllProcesses.Migrations
{
    public partial class AlterColumnValentineOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ValentineOptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ValentineOptions");
        }
    }
}
