using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class SecondMigration_IncludesAllEntititesWithReviseedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Employee_EmployeeID",
                table: "Assignment");

            migrationBuilder.DropTable(
                name: "CustomerSalesViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_EmployeeID",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Assignment");

            migrationBuilder.CreateTable(
                name: "AssignmentEmployee",
                columns: table => new
                {
                    AssignmentsAssignmentID = table.Column<int>(type: "int", nullable: false),
                    EmployeesEmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentEmployee", x => new { x.AssignmentsAssignmentID, x.EmployeesEmployeeID });
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Assignment_AssignmentsAssignmentID",
                        column: x => x.AssignmentsAssignmentID,
                        principalTable: "Assignment",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Employee_EmployeesEmployeeID",
                        column: x => x.EmployeesEmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLedger",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    ChequeNumber = table.Column<int>(type: "int", nullable: false),
                    TransactionInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLedger", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_CustomerLedger_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLedgerViewModel",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    ChequeNumber = table.Column<long>(type: "bigint", nullable: false),
                    TransactionTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLedgerViewModel", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_CustomerLedgerViewModel_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendorLedger",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    ChequeNumber = table.Column<long>(type: "bigint", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorLedger", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_VendorLedger_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendorLedgerViewModel",
                columns: table => new
                {
                    VendorLedgerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    ChequeNumber = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorLedgerViewModel", x => x.VendorLedgerID);
                    table.ForeignKey(
                        name: "FK_VendorLedgerViewModel_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentEmployee_EmployeesEmployeeID",
                table: "AssignmentEmployee",
                column: "EmployeesEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLedger_CustomerID",
                table: "CustomerLedger",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLedgerViewModel_CustomerID",
                table: "CustomerLedgerViewModel",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_VendorLedger_VendorID",
                table: "VendorLedger",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_VendorLedgerViewModel_VendorID",
                table: "VendorLedgerViewModel",
                column: "VendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentEmployee");

            migrationBuilder.DropTable(
                name: "CustomerLedger");

            migrationBuilder.DropTable(
                name: "CustomerLedgerViewModel");

            migrationBuilder.DropTable(
                name: "VendorLedger");

            migrationBuilder.DropTable(
                name: "VendorLedgerViewModel");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Assignment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerSalesViewModel",
                columns: table => new
                {
                    CustomerSalesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNo = table.Column<int>(type: "int", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContact = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSalesViewModel", x => x.CustomerSalesID);
                    table.ForeignKey(
                        name: "FK_CustomerSalesViewModel_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_EmployeeID",
                table: "Assignment",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSalesViewModel_CustomerID",
                table: "CustomerSalesViewModel",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Employee_EmployeeID",
                table: "Assignment",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
