using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDrinkAndGo.Migrations
{
    public partial class Dbv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 2,
                column: "IsPreferredDrink",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 2,
                column: "IsPreferredDrink",
                value: false);
        }
    }
}
