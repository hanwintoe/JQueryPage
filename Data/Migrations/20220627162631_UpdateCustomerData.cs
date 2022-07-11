using Microsoft.EntityFrameworkCore.Migrations;

namespace JQueryPage.Data.Migrations
{
    public partial class UpdateCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Drink",
                table: "Customers",
                newName: "drink");

            migrationBuilder.AddColumn<string>(
                name: "SecretData",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretData",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "drink",
                table: "Customers",
                newName: "Drink");
        }
    }
}
