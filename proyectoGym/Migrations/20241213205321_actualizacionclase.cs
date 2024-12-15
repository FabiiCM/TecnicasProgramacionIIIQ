using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoGym.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionclase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membresias_Personas_ClienteId",
                table: "Membresias");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Membresias",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Membresias_ClienteId",
                table: "Membresias",
                newName: "IX_Membresias_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Membresias_Personas_ClienteID",
                table: "Membresias",
                column: "ClienteID",
                principalTable: "Personas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membresias_Personas_ClienteID",
                table: "Membresias");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Membresias",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Membresias_ClienteID",
                table: "Membresias",
                newName: "IX_Membresias_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membresias_Personas_ClienteId",
                table: "Membresias",
                column: "ClienteId",
                principalTable: "Personas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
