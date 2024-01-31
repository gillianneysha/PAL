using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDACStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "SlotsINV",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "Tinyint");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "Status",
                value: "Occupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 2,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "Status",
                value: "Occupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 4,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 5,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 6,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 7,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 8,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 9,
                column: "Status",
                value: "Unoccupied");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 10,
                column: "Status",
                value: "Unoccupied");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "SlotsINV",
                type: "Tinyint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 2,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 4,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 5,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 6,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 7,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 8,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 9,
                column: "Status",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 10,
                column: "Status",
                value: (byte)0);
        }
    }
}
