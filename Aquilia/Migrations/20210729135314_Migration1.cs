using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "DebitAndCreditReportViewModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits",
                column: "FinalProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits");

            migrationBuilder.AlterColumn<string>(
                name: "Rate",
                table: "DebitAndCreditReportViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits",
                column: "FinalProductID",
                unique: true);
        }
    }
}
