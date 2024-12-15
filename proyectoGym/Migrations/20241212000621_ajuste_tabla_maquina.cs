using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoGym.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_tabla_maquina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maquinas_Inventarios_InventarioID",
                table: "Maquinas");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropIndex(
                name: "IX_Maquinas_InventarioID",
                table: "Maquinas");

            migrationBuilder.DropColumn(
                name: "InventarioID",
                table: "Maquinas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventarioID",
                table: "Maquinas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maquinas_InventarioID",
                table: "Maquinas",
                column: "InventarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Maquinas_Inventarios_InventarioID",
                table: "Maquinas",
                column: "InventarioID",
                principalTable: "Inventarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
