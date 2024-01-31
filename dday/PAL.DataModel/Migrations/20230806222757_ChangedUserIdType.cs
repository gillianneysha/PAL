using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUserIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "SlotsINV",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PETERSlotsINV",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "DOMINGASlotsINV",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CampusReserveINV",
                type: "nvarchar(MAX)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AKICSlotsINV",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 10,
                column: "UserId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SlotsINV",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PETERSlotsINV",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "DOMINGASlotsINV",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CampusReserveINV",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "AKICSlotsINV",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 10,
                column: "UserId",
                value: null);
        }
    }
}
