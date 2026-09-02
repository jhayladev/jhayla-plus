using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JhaylaPlusAPI.Migrations.UsuariosDb
{
    /// <inheritdoc />
    public partial class UsuariosDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "Contraseña", "Correo", "Nombre" },
                values: new object[,]
                {
                    { 1, "Nuñez", "1234", "addununeznunezavila@gmail.com", "Addu" },
                    { 2, "Frias", "1234", "luis.frias@gmail.com", "Luis" },
                    { 3, "Rincones", "1234", "andres.rincones@gmail.com", "Andres" },
                    { 4, "Florez", "1234", "rafael.florez@gmail.com", "Rafael" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
