using Microsoft.EntityFrameworkCore.Migrations;

namespace JQueryPage.Data.Migrations
{
    public partial class ChangeBackModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "drink",
                table: "Customers",
                newName: "Drink");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Drink",
                table: "Customers",
                newName: "drink");
        }
    }
}
