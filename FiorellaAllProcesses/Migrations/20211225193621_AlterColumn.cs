using Microsoft.EntityFrameworkCore.Migrations;

namespace FiorellaAllProcesses.Migrations
{
    public partial class AlterColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Сurrencies_СurrencyId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "СurrencyId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Сurrencies_СurrencyId",
                table: "Products",
                column: "СurrencyId",
                principalTable: "Сurrencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Сurrencies_СurrencyId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "СurrencyId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Сurrencies_СurrencyId",
                table: "Products",
                column: "СurrencyId",
                principalTable: "Сurrencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
