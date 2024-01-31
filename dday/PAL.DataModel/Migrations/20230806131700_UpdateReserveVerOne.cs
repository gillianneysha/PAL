using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReserveVerOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "SlotsINV");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "PETERSlotsINV");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "DOMINGASlotsINV");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "AKICSlotsINV");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "SlotsINV",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "PETERSlotsINV",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "DOMINGASlotsINV",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "AKICSlotsINV",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CampusReserveINV",
                columns: table => new
                {
                    CampusReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Campus = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusReserveINV", x => x.CampusReservationId);
                });

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 1,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 2,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 3,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 4,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 5,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 6,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 7,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 8,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 9,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 10,
                column: "Campus",
                value: "AKIC");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 1,
                column: "Campus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 2,
                column: "Campus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 3,
                column: "Campus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 4,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 5,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 6,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 7,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 8,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 9,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 10,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 1,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 2,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 3,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 4,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 5,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 6,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 7,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 8,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 9,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 10,
                column: "Campus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 2,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 4,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 5,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 6,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 7,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 8,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 9,
                column: "Campus",
                value: "DAC");

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 10,
                column: "Campus",
                value: "DAC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampusReserveINV");

            migrationBuilder.DropColumn(
                name: "Campus",
                table: "SlotsINV");

            migrationBuilder.DropColumn(
                name: "Campus",
                table: "PETERSlotsINV");

            migrationBuilder.DropColumn(
                name: "Campus",
                table: "DOMINGASlotsINV");

            migrationBuilder.DropColumn(
                name: "Campus",
                table: "AKICSlotsINV");

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "SlotsINV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "PETERSlotsINV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "DOMINGASlotsINV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "AKICSlotsINV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 1,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 2,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 3,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 4,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 5,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 6,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 7,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 8,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 9,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AKICSlotsINV",
                keyColumn: "AKICSlotId",
                keyValue: 10,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 1,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 2,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 3,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 4,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 5,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 6,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 7,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 8,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 9,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 10,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 1,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 2,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 3,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 4,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 5,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 6,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 7,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 8,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 9,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PETERSlotsINV",
                keyColumn: "PETERSlotId",
                keyValue: 10,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 1,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 2,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 3,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 4,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 5,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 6,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 7,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 8,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 9,
                column: "CampusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SlotsINV",
                keyColumn: "DACSlotId",
                keyValue: 10,
                column: "CampusId",
                value: 1);
        }
    }
}
