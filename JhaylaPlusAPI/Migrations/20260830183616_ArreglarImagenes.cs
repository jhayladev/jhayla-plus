using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JhaylaPlusAPI.Migrations
{
    /// <inheritdoc />
    public partial class ArreglarImagenes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 2026);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagenUrl",
                value: "https://m.media-amazon.com/images/M/MV5BNGEwYWZkN2UtOTQ5Mi00MGQzLWEzNjYtMWMyNDBkMTkzMWNkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImagenUrl", "Year" },
                values: new object[] { "https://assets.cinemark-core.com/5db771be04daec00076df3f5/vista/movies/6a22d1b9720d1d2a7f8d9a19/common/spiderman-nuevo-dia-109320-1780678232870", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagenUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkmVRJ71XkUcnm_DAc2_d4_Iw9oX6bqu9lIY4Zz9a9ZlLOCDINM4dnX0zj&s=10");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagenUrl",
                value: "https://static.wikia.nocookie.net/disney/images/7/76/Moana_official_poster.jpg/revision/latest?cb=20160921035605&path-prefix=es");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagenUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7zjfqxpuf0AHiQ-y2EvPuNku-JVcGZH2-_puckCF_sRdwbiKGdeF2tcqs&s=10");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImagenUrl", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMjI5YTQ3YmItZjk1ZS00ZDBmLWJhZDMtNThhMDI5ZTRkMTcxXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", 2026 });

            // Nota: los Id 8-27 NO se insertan aquí. Ya fueron insertados por la
            // migración anterior (AgregarMasPeliculas). Insertarlos de nuevo con el
            // mismo Id provocaba un choque de clave primaria que hacía fallar esta
            // migración y dejaba sin aplicar el resto (por eso el catálogo quedaba
            // incompleto al hacer Update-Database desde cero).
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 2024);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagenUrl",
                value: "https://m.media-amazon.com/images/M/MV5B...");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImagenUrl", "Year" },
                values: new object[] { "https://assets.cinemark-core.com/5db771be04daec0...", 2021 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagenUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ...");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagenUrl",
                value: "https://static.wikia.nocookie.net/disney/images/7/76...");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagenUrl",
                value: "https://encrypted-tbn0.gstatic.com/images...");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImagenUrl", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMjI...", 2009 });
        }
    }
}
