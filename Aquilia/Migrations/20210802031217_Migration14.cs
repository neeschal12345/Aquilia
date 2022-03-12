using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class Migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MiscID",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Misc",
                columns: table => new
                {
                    MiscID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Misc", x => x.MiscID);
                });

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Misc_MiscID",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Misc");

            migrationBuilder.DropIndex(
                name: "IX_Employee_MiscID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MiscID",
                table: "Employee");
        }
    }
}
