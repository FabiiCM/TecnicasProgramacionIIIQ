using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoGym.Migrations
{
    /// <inheritdoc />
    public partial class Nuevas_Clases_Datos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Personas_EntrenadorID",
                table: "Clases");

            migrationBuilder.AddColumn<int>(
                name: "Registradas",
                table: "Clases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Metricas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    IMC = table.Column<double>(type: "float", nullable: false),
                    Cintura = table.Column<double>(type: "float", nullable: false),
                    Cadera = table.Column<double>(type: "float", nullable: false),
                    Brazo = table.Column<double>(type: "float", nullable: false),
                    Muslo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metricas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Metricas_Personas_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Personas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAsignación = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rutinas_Personas_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Personas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Metricas_ClienteID",
                table: "Metricas",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Rutinas_ClienteID",
                table: "Rutinas",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Personas_EntrenadorID",
                table: "Clases",
                column: "EntrenadorID",
                principalTable: "Personas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Personas_EntrenadorID",
                table: "Clases");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Metricas");

            migrationBuilder.DropTable(
                name: "Rutinas");

            migrationBuilder.DropColumn(
                name: "Registradas",
                table: "Clases");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Personas_EntrenadorID",
                table: "Clases",
                column: "EntrenadorID",
                principalTable: "Personas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
