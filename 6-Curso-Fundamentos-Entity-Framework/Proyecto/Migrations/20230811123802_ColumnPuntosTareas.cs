using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyectoef.Migrations
{
    /// <inheritdoc />
    public partial class ColumnPuntosTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Puntos",
                table: "Tareas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puntos",
                table: "Tareas");
        }
    }
}
