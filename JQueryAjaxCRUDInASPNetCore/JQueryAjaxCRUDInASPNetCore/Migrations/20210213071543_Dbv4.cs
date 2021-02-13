using Microsoft.EntityFrameworkCore.Migrations;

namespace JQueryAjaxCRUDInASPNetCore.Migrations
{
    public partial class Dbv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionModel",
                table: "TransactionModel");

            migrationBuilder.RenameTable(
                name: "TransactionModel",
                newName: "Transactions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "TransactionModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionModel",
                table: "TransactionModel",
                column: "Id");
        }
    }
}
