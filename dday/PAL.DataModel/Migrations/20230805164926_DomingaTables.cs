using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class DomingaTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOMINGAReserveINV",
                columns: table => new
                {
                    DOMINGAReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DOMINGASlotId = table.Column<int>(type: "int", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMINGAReserveINV", x => x.DOMINGAReservationId);
                });

            migrationBuilder.CreateTable(
                name: "DOMINGASlotsINV",
                columns: table => new
                {
                    DOMINGASlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DOMINGAReservationId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMINGASlotsINV", x => x.DOMINGASlotId);
                });

            migrationBuilder.InsertData(
                table: "DOMINGASlotsINV",
                columns: new[] { "DOMINGASlotId", "CampusId", "DOMINGAReservationId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, "Unoccupied", null },
                    { 2, 1, null, "Unoccupied", null },
                    { 3, 1, null, "Unoccupied", null },
                    { 4, 1, null, "Unoccupied", null },
                    { 5, 1, null, "Unoccupied", null },
                    { 6, 1, null, "Unoccupied", null },
                    { 7, 1, null, "Unoccupied", null },
                    { 8, 1, null, "Unoccupied", null },
                    { 9, 1, null, "Unoccupied", null },
                    { 10, 1, null, "Unoccupied", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOMINGAReserveINV");

            migrationBuilder.DropTable(
                name: "DOMINGASlotsINV");
        }
    }
}
