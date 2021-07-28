using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class SecondMigration_IncludesAllEntititesWith : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorLedger");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "VendorLedgerViewModel");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "RawMaterials",
                newName: "ChequeNumber");

            migrationBuilder.RenameColumn(
                name: "RawMaterialPrice",
                table: "RawMaterials",
                newName: "VoucherNo");

            migrationBuilder.RenameColumn(
                name: "RawMaterialName",
                table: "RawMaterials",
                newName: "Description");

            migrationBuilder.AlterColumn<long>(
                name: "ChequeNumber",
                table: "VendorLedgerViewModel",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreditAmount",
                table: "VendorLedgerViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DebitAmount",
                table: "VendorLedgerViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "Quantity",
                table: "VendorLedgerViewModel",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "VendorLedgerViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TransactionDate",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreditAmount",
                table: "RawMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentBalance",
                table: "RawMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "RawMaterials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DebitAmount",
                table: "RawMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "RawMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSalesViewModel_CustomerID",
                table: "CustomerSalesViewModel",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerSalesViewModel");

            migrationBuilder.DropColumn(
                name: "CreditAmount",
                table: "VendorLedgerViewModel");

            migrationBuilder.DropColumn(
                name: "DebitAmount",
                table: "VendorLedgerViewModel");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "VendorLedgerViewModel");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "VendorLedgerViewModel");

            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CreditAmount",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "CurrentBalance",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "DebitAmount",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "RawMaterials");

            migrationBuilder.RenameColumn(
                name: "VoucherNo",
                table: "RawMaterials",
                newName: "RawMaterialPrice");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "RawMaterials",
                newName: "RawMaterialName");

            migrationBuilder.RenameColumn(
                name: "ChequeNumber",
                table: "RawMaterials",
                newName: "TotalAmount");

            migrationBuilder.AlterColumn<int>(
                name: "ChequeNumber",
                table: "VendorLedgerViewModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "VendorLedgerViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "VendorLedger",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ChequeNumber = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBalance = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    VoucherNo = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_VendorLedger_VendorID",
                table: "VendorLedger",
                column: "VendorID");
        }
    }
}
