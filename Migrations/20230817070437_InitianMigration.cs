using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Race_Track.Migrations
{
    /// <inheritdoc />
    public partial class InitianMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehiculoNombre = table.Column<string>(type: "TEXT", nullable: true),
                    VehiculoApellido = table.Column<string>(type: "TEXT", nullable: true),
                    VehiculoTipo = table.Column<string>(type: "TEXT", nullable: true),
                    VehiculoMatricula = table.Column<string>(type: "TEXT", nullable: true),
                    VehiculoFabricacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Piloto",
                columns: table => new
                {
                    PilotoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PilotoNombre = table.Column<string>(type: "TEXT", nullable: true),
                    PilotoApellido = table.Column<string>(type: "TEXT", nullable: true),
                    PilotoDni = table.Column<int>(type: "INTEGER", nullable: false),
                    PilotoNumeroLicencia = table.Column<int>(type: "INTEGER", nullable: false),
                    PilotoExpedicion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PilotoPropietario = table.Column<bool>(type: "INTEGER", nullable: false),
                    VehiculoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloto", x => x.PilotoId);
                    table.ForeignKey(
                        name: "FK_Piloto_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Piloto_VehiculoId",
                table: "Piloto",
                column: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piloto");

            migrationBuilder.DropTable(
                name: "Vehiculo");
        }
    }
}
