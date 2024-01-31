using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class TableUpdateVerTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Campus",
                table: "SlotsINV",
                newName: "DACCampus");

            migrationBuilder.RenameColumn(
                name: "Campus",
                table: "PETERSlotsINV",
                newName: "PETERCampus");

            migrationBuilder.RenameColumn(
                name: "Campus",
                table: "DOMINGASlotsINV",
                newName: "DOMINGACampus");

            migrationBuilder.RenameColumn(
                name: "Campus",
                table: "AKICSlotsINV",
                newName: "AKICCampus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DACCampus",
                table: "SlotsINV",
                newName: "Campus");

            migrationBuilder.RenameColumn(
                name: "PETERCampus",
                table: "PETERSlotsINV",
                newName: "Campus");

            migrationBuilder.RenameColumn(
                name: "DOMINGACampus",
                table: "DOMINGASlotsINV",
                newName: "Campus");

            migrationBuilder.RenameColumn(
                name: "AKICCampus",
                table: "AKICSlotsINV",
                newName: "Campus");
        }
    }
}
