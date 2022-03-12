using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class SecondMigration_IncludesAllEntititesx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "DebitAndCreditReportViewModel");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "DebitCredits",
                newName: "StockStatus");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "DebitCredits",
                newName: "Quantity");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "DebitCredits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "CreditAmount",
                table: "DebitCredits",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DebitAmount",
                table: "DebitCredits",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "FinalProductID",
                table: "DebitCredits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "DebitCredits",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "DebitCredits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "DebitAndCreditReportViewModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CreditAmount",
                table: "DebitAndCreditReportViewModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DebitAmount",
                table: "DebitAndCreditReportViewModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Rate",
                table: "DebitAndCreditReportViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "DebitAndCreditReportViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits",
                column: "FinalProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_DebitCredits_FinalProduct_FinalProductID",
                table: "DebitCredits",
                column: "FinalProductID",
                principalTable: "FinalProduct",
                principalColumn: "FinalProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DebitCredits_FinalProduct_FinalProductID",
                table: "DebitCredits");

            migrationBuilder.DropIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "CreditAmount",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "DebitAmount",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "FinalProductID",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "DebitCredits");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "DebitAndCreditReportViewModel");

            migrationBuilder.DropColumn(
                name: "CreditAmount",
                table: "DebitAndCreditReportViewModel");

            migrationBuilder.DropColumn(
                name: "DebitAmount",
                table: "DebitAndCreditReportViewModel");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "DebitAndCreditReportViewModel");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "DebitAndCreditReportViewModel");

            migrationBuilder.RenameColumn(
                name: "StockStatus",
                table: "DebitCredits",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "DebitCredits",
                newName: "Amount");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "DebitCredits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "DebitCredits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "DebitAndCreditReportViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
