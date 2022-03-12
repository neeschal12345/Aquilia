using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VendorState",
                table: "Vendor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CopperQty",
                table: "ProductandProductPartsViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DashboardViewModel",
                columns: table => new
                {
                    DashboardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletedAssignments = table.Column<int>(type: "int", nullable: false),
                    PendingAssignments = table.Column<int>(type: "int", nullable: false),
                    FinalProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<int>(type: "int", nullable: false),
                    PendingProductQty = table.Column<int>(type: "int", nullable: false),
                    ActiveVendors = table.Column<int>(type: "int", nullable: false),
                    ActiveEmployees = table.Column<int>(type: "int", nullable: false),
                    RawMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RawmaterialQuantity = table.Column<int>(type: "int", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPartQty = table.Column<int>(type: "int", nullable: false),
                    CopperQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfitLossStatus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardViewModel", x => x.DashboardID);
                    table.ForeignKey(
                        name: "FK_DashboardViewModel_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DashboardViewModel_EmployeeID",
                table: "DashboardViewModel",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardViewModel");

            migrationBuilder.DropColumn(
                name: "VendorState",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CopperQty",
                table: "ProductandProductPartsViewModel");
        }
    }
}
