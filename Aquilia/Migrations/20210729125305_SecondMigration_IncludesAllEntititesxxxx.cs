using Microsoft.EntityFrameworkCore.Migrations;

namespace Aquilia.Migrations
{
    public partial class SecondMigration_IncludesAllEntititesxxxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits");

            migrationBuilder.CreateIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits",
                column: "FinalProductID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits");

            migrationBuilder.CreateIndex(
                name: "IX_DebitCredits_FinalProductID",
                table: "DebitCredits",
                column: "FinalProductID");
        }
    }
}
