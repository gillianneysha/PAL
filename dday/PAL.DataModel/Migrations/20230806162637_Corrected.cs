using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class Corrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 4,
                column: "DOMINGACampus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 5,
                column: "DOMINGACampus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 6,
                column: "DOMINGACampus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 7,
                column: "DOMINGACampus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 8,
                column: "DOMINGACampus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 9,
                column: "DOMINGACampus",
                value: "DOMINGA");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 10,
                column: "DOMINGACampus",
                value: "DOMINGA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 4,
                column: "DOMINGACampus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 5,
                column: "DOMINGACampus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 6,
                column: "DOMINGACampus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 7,
                column: "DOMINGACampus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 8,
                column: "DOMINGACampus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 9,
                column: "DOMINGACampus",
                value: "PDGII");

            migrationBuilder.UpdateData(
                table: "DOMINGASlotsINV",
                keyColumn: "DOMINGASlotId",
                keyValue: 10,
                column: "DOMINGACampus",
                value: "PDGII");
        }
    }
}
