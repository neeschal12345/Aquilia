using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class SecondMigration_IncludesAllEntititesWithRevise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PANNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSalesViewModel",
                columns: table => new
                {
                    CustomerSalesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillNo = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContact = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "FinalProduct",
                columns: table => new
                {
                    FinalProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalProduct", x => x.FinalProductID);
                    table.ForeignKey(
                        name: "FK_FinalProduct_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNo = table.Column<int>(type: "int", nullable: false),
                    RawMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RawMaterialPrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<short>(type: "smallint", nullable: false),
                    TotalAmount = table.Column<long>(type: "bigint", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialID);
                    table.ForeignKey(
                        name: "FK_RawMaterials_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendorPurchasesViewModel",
                columns: table => new
                {
                    VendorPurchaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillNo = table.Column<int>(type: "int", nullable: false),
                    particularName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorPurchasesViewModel", x => x.VendorPurchaseID);
                    table.ForeignKey(
                        name: "FK_VendorPurchasesViewModel_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Vendor",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductandProductPartsViewModel",
                columns: table => new
                {
                    ProductandProductPartsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinalProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productPartCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaxComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalProductID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductandProductPartsViewModel", x => x.ProductandProductPartsID);
                    table.ForeignKey(
                        name: "FK_ProductandProductPartsViewModel_FinalProduct_FinalProductID",
                        column: x => x.FinalProductID,
                        principalTable: "FinalProduct",
                        principalColumn: "FinalProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductParts",
                columns: table => new
                {
                    ProductPartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductPartNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPartCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPartQuantity = table.Column<int>(type: "int", nullable: false),
                    WaxComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CopperComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductParts", x => x.ProductPartID);
                    table.ForeignKey(
                        name: "FK_ProductParts_FinalProduct_FinalProductID",
                        column: x => x.FinalProductID,
                        principalTable: "FinalProduct",
                        principalColumn: "FinalProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SalesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNo = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    FinalProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SalesID);
                    table.ForeignKey(
                        name: "FK_Sales_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_FinalProduct_FinalProductID",
                        column: x => x.FinalProductID,
                        principalTable: "FinalProduct",
                        principalColumn: "FinalProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPartsProductPartID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_ProductParts_ProductPartsProductPartID",
                        column: x => x.ProductPartsProductPartID,
                        principalTable: "ProductParts",
                        principalColumn: "ProductPartID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPartID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.AssignmentID);
                    table.ForeignKey(
                        name: "FK_Assignment_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_ProductParts_ProductPartID",
                        column: x => x.ProductPartID,
                        principalTable: "ProductParts",
                        principalColumn: "ProductPartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtttendantEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttendentDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceID);
                    table.ForeignKey(
                        name: "FK_Attendance_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DebitAndCreditReportViewModel",
                columns: table => new
                {
                    DebitCreditID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeNo = table.Column<int>(type: "int", nullable: false),
                    VoucherID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitAndCreditReportViewModel", x => x.DebitCreditID);
                    table.ForeignKey(
                        name: "FK_DebitAndCreditReportViewModel_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DebitCredits",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitCredits", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_DebitCredits_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment_RawMaterials",
                columns: table => new
                {
                    AssignmentRawMaterialsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RawMaterialID = table.Column<int>(type: "int", nullable: false),
                    AssignmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment_RawMaterials", x => x.AssignmentRawMaterialsID);
                    table.ForeignKey(
                        name: "FK_Assignment_RawMaterials_Assignment_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignment",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignment_RawMaterials_RawMaterials_RawMaterialID",
                        column: x => x.RawMaterialID,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentLog",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedState = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentLog", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_AssignmentLog_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentLog_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAssignmentsViewModel",
                columns: table => new
                {
                    EmployeeAssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductPartCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedProductPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedQuantity = table.Column<int>(type: "int", nullable: false),
                    AssignmentState = table.Column<int>(type: "int", nullable: false),
                    FinalProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAssignmentsViewModel", x => x.EmployeeAssignmentID);
                    table.ForeignKey(
                        name: "FK_EmployeeAssignmentsViewModel_Assignment_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignment",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    SalaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaryMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.SalaryID);
                    table.ForeignKey(
                        name: "FK_Salary_Attendance_AttendanceID",
                        column: x => x.AttendanceID,
                        principalTable: "Attendance",
                        principalColumn: "AttendanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_EmployeeID",
                table: "Assignment",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_ProductPartID",
                table: "Assignment",
                column: "ProductPartID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_RawMaterials_AssignmentID",
                table: "Assignment_RawMaterials",
                column: "AssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_RawMaterials_RawMaterialID",
                table: "Assignment_RawMaterials",
                column: "RawMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentLog_AssignmentId",
                table: "AssignmentLog",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentLog_EmployeeID",
                table: "AssignmentLog",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_EmployeeID",
                table: "Attendance",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSalesViewModel_CustomerID",
                table: "CustomerSalesViewModel",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DebitAndCreditReportViewModel_EmployeeID",
                table: "DebitAndCreditReportViewModel",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_DebitCredits_EmployeeID",
                table: "DebitCredits",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProductPartsProductPartID",
                table: "Employee",
                column: "ProductPartsProductPartID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignmentsViewModel_AssignmentID",
                table: "EmployeeAssignmentsViewModel",
                column: "AssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_FinalProduct_CustomerID",
                table: "FinalProduct",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductandProductPartsViewModel_FinalProductID",
                table: "ProductandProductPartsViewModel",
                column: "FinalProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductParts_FinalProductID",
                table: "ProductParts",
                column: "FinalProductID");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_VendorID",
                table: "RawMaterials",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_Salary_AttendanceID",
                table: "Salary",
                column: "AttendanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerID",
                table: "Sales",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_FinalProductID",
                table: "Sales",
                column: "FinalProductID");

            migrationBuilder.CreateIndex(
                name: "IX_VendorPurchasesViewModel_VendorID",
                table: "VendorPurchasesViewModel",
                column: "VendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment_RawMaterials");

            migrationBuilder.DropTable(
                name: "AssignmentLog");

            migrationBuilder.DropTable(
                name: "CustomerSalesViewModel");

            migrationBuilder.DropTable(
                name: "DebitAndCreditReportViewModel");

            migrationBuilder.DropTable(
                name: "DebitCredits");

            migrationBuilder.DropTable(
                name: "EmployeeAssignmentsViewModel");

            migrationBuilder.DropTable(
                name: "ProductandProductPartsViewModel");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "VendorPurchasesViewModel");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ProductParts");

            migrationBuilder.DropTable(
                name: "FinalProduct");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
