using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JhaylaPlusAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPeliculasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "ImagenUrl", "Titulo", "Year" },
                values: new object[,]
                {
                    { 1, "/images/ojitoscute.png", "Nuestro hilo rojo a distancia", 2024 },
                    { 2, "https://m.media-amazon.com/images/M/MV5B...", "Avengers Doomsday", 2026 },
                    { 3, "https://assets.cinemark-core.com/5db771be04daec0...", "Spiderman", 2021 },
                    { 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ...", "It", 2017 },
                    { 5, "https://static.wikia.nocookie.net/disney/images/7/76...", "Moana", 2016 },
                    { 6, "https://encrypted-tbn0.gstatic.com/images...", "Son como niños 2", 2013 },
                    { 7, "https://m.media-amazon.com/images/M/MV5BMjI...", "The last house", 2009 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
