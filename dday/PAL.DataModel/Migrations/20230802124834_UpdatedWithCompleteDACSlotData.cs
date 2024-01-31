using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedWithCompleteDACSlotData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DACReserveINV",
                columns: table => new
                {
                    DACReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DACSlotId = table.Column<int>(type: "int", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DACReserveINV", x => x.DACReservationId);
                });

            migrationBuilder.CreateTable(
                name: "SlotsINV",
                columns: table => new
                {
                    DACSlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DACReservationId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<byte>(type: "Tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotsINV", x => x.DACSlotId);
                });

            migrationBuilder.InsertData(
                table: "SlotsINV",
                columns: new[] { "DACSlotId", "CampusId", "DACReservationId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, (byte)0, null },
                    { 2, 1, null, (byte)0, null },
                    { 3, 1, null, (byte)0, null },
                    { 4, 1, null, (byte)0, null },
                    { 5, 1, null, (byte)0, null },
                    { 6, 1, null, (byte)0, null },
                    { 7, 1, null, (byte)0, null },
                    { 8, 1, null, (byte)0, null },
                    { 9, 1, null, (byte)0, null },
                    { 10, 1, null, (byte)0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DACReserveINV");

            migrationBuilder.DropTable(
                name: "SlotsINV");
        }
    }
}
