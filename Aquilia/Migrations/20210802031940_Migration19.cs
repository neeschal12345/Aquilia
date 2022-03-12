using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class Migration19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Misc_MiscID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_MiscID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MiscID",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MiscID",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MiscID",
                table: "Employee",
                column: "MiscID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Misc_MiscID",
                table: "Employee",
                column: "MiscID",
                principalTable: "Misc",
                principalColumn: "MiscID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
