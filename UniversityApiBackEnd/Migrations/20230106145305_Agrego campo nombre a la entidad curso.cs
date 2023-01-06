using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityApiBackEnd.Migrations
{
    public partial class Agregocamponombrealaentidadcurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Cursos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Cursos");
        }
    }
}
