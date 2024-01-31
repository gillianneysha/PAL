using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class WithAkic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AKICReserveINV",
                columns: table => new
                {
                    AKICReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AKICSlotId = table.Column<int>(type: "int", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AKICReserveINV", x => x.AKICReservationId);
                });

            migrationBuilder.CreateTable(
                name: "AKICSlotsINV",
                columns: table => new
                {
                    AKICSlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    AKICReservationId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AKICSlotsINV", x => x.AKICSlotId);
                });

            migrationBuilder.InsertData(
                table: "AKICSlotsINV",
                columns: new[] { "AKICSlotId", "AKICReservationId", "CampusId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, "Unoccupied", null },
                    { 2, null, 1, "Unoccupied", null },
                    { 3, null, 1, "Unoccupied", null },
                    { 4, null, 1, "Unoccupied", null },
                    { 5, null, 1, "Unoccupied", null },
                    { 6, null, 1, "Unoccupied", null },
                    { 7, null, 1, "Unoccupied", null },
                    { 8, null, 1, "Unoccupied", null },
                    { 9, null, 1, "Unoccupied", null },
                    { 10, null, 1, "Unoccupied", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AKICReserveINV");

            migrationBuilder.DropTable(
                name: "AKICSlotsINV");
        }
    }
}
