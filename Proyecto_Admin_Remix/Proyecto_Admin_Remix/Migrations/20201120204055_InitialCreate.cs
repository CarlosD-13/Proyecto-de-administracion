using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Admin_Remix.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropiedadesEN",
                columns: table => new
                {
                    InmuebleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Habitaciones = table.Column<int>(type: "int", nullable: false),
                    Baños = table.Column<int>(type: "int", nullable: false),
                    Parqueo = table.Column<int>(type: "int", nullable: false),
                    Opcion = table.Column<string>(type: "varchar(15)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Imagen = table.Column<string>(type: "varchar(max)", nullable: false),
                    Observacion = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropiedadesEN", x => x.InmuebleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropiedadesEN");
        }
    }
}
