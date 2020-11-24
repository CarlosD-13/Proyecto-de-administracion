using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Admin_Remix.Migrations.Formularios
{
    public partial class formulario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormulariosEN",
                columns: table => new
                {
                    FormularioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    correo = table.Column<string>(type: "varchar(max)", nullable: false),
                    celular = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    Nacionalidad = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(25)", nullable: false),
                    Fech_Naciemento = table.Column<string>(type: "varchar(30)", nullable: false),
                    Estado_civil = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulariosEN", x => x.FormularioID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormulariosEN");
        }
    }
}
