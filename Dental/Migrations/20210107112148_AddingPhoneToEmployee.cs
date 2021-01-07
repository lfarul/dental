using Microsoft.EntityFrameworkCore.Migrations;

namespace Dental.Migrations
{
    public partial class AddingPhoneToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");
        }
    }
}
