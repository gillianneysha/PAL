using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "Status",
                value: "Unoccupied");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "Status",
                value: "Occupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "Status",
                value: "Occupied");
        }
    }
}
