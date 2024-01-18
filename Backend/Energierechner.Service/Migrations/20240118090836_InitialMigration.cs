using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Energierechner.Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricityMeters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ElectricityMeterNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicPrice = table.Column<double>(type: "float", nullable: false),
                    UnitPreice = table.Column<double>(type: "float", nullable: false),
                    ConsumptionTarget = table.Column<long>(type: "bigint", nullable: false),
                    MonthlyPayment = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GasMeters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasMeters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotWaterMeters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotWaterMeters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeterReadings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reading = table.Column<long>(type: "bigint", nullable: false),
                    ElectricityMeterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeterReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricityMeterReadings_ElectricityMeters_ElectricityMeterId",
                        column: x => x.ElectricityMeterId,
                        principalTable: "ElectricityMeters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeterReadings_ElectricityMeterId",
                table: "ElectricityMeterReadings",
                column: "ElectricityMeterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricityMeterReadings");

            migrationBuilder.DropTable(
                name: "GasMeters");

            migrationBuilder.DropTable(
                name: "HotWaterMeters");

            migrationBuilder.DropTable(
                name: "ElectricityMeters");
        }
    }
}
