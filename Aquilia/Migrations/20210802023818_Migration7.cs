using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VendorState",
                table: "Vendor",
                newName: "Active");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Vendor",
                newName: "VendorState");
        }
    }
}
