using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoGym.Migrations
{
    /// <inheritdoc />
    public partial class Prueba_Clase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Personas_ClienteID",
                table: "Rutinas");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Rutinas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Personas_ClienteID",
                table: "Rutinas",
                column: "ClienteID",
                principalTable: "Personas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Personas_ClienteID",
                table: "Rutinas");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Rutinas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Personas_ClienteID",
                table: "Rutinas",
                column: "ClienteID",
                principalTable: "Personas",
                principalColumn: "ID");
        }
    }
}
