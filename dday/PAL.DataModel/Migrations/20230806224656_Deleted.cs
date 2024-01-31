using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAL.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class Deleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AKICReserveINV");

            migrationBuilder.DropTable(
                name: "DACReserveINV");

            migrationBuilder.DropTable(
                name: "DOMINGAReserveINV");

            migrationBuilder.DropTable(
                name: "PETERReserveINV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AKICReserveINV",
                columns: table => new
                {
                    AKICReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AKICSlotId = table.Column<int>(type: "int", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AKICReserveINV", x => x.AKICReservationId);
                });

            migrationBuilder.CreateTable(
                name: "DACReserveINV",
                columns: table => new
                {
                    DACReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DACSlotId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DACReserveINV", x => x.DACReservationId);
                });

            migrationBuilder.CreateTable(
                name: "DOMINGAReserveINV",
                columns: table => new
                {
                    DOMINGAReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DOMINGASlotId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMINGAReserveINV", x => x.DOMINGAReservationId);
                });

            migrationBuilder.CreateTable(
                name: "PETERReserveINV",
                columns: table => new
                {
                    PETERReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    PETERSlotId = table.Column<int>(type: "int", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime2(7)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PETERReserveINV", x => x.PETERReservationId);
                });
        }
    }
}
