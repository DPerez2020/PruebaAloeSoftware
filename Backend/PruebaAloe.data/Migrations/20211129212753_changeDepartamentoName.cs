using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaAloe.data.Migrations
{
    public partial class changeDepartamentoName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Departamento",
                newName: "Nombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Departamento",
                newName: "Descripcion");
        }
    }
}
