using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JhaylaPlusAPI.Migrations
{
    /// <inheritdoc />
    public partial class AgregarMasPeliculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "ImagenUrl", "Titulo", "Year" },
                values: new object[,]
                {
                    { 8, "https://es.web.img2.acsta.net/medias/nmedia/18/68/79/58/19045139.jpg", "Un chihuahua en Beverly Hills", 2008 },
                    { 9, "https://es.web.img2.acsta.net/pictures/14/11/19/16/01/398307.jpg", "Cenicienta", 2015 },
                    { 10, "https://es.web.img3.acsta.net/medias/nmedia/18/79/96/30/19541005.jpg", "Rapunzel", 2010 },
                    { 11, "https://m.media-amazon.com/images/M/MV5BMTg5NzY0MzA2MV5BMl5BanBnXkFtZTYwNDc3NTc2._V1_FMjpg_UX1000_.jpg", "Cars: Una aventura sobre ruedas", 2006 },
                    { 12, "https://es.web.img3.acsta.net/pictures/14/03/17/10/20/509771.jpg", "Toy Story", 1995 },
                    { 13, "https://es.web.img3.acsta.net/pictures/17/01/09/09/56/256507.jpg", "La bella y la bestia", 2017 },
                    { 14, "https://m.media-amazon.com/images/M/MV5BOTE3YTExYTEtOTUxZC00OTM0LWJmYmItMDk5YjczNmIwNzA2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "La princesa y el sapo", 2009 },
                    { 15, "https://es.web.img3.acsta.net/pictures/14/03/11/09/33/450247.jpg", "Malefica", 2014 },
                    { 16, "https://static.wikia.nocookie.net/doblaje/images/5/56/MLFCDMCartel.jpg/revision/latest?cb=20190927034818&path-prefix=es", "Malefica 2", 2019 },
                    { 17, "https://static.wikia.nocookie.net/doblaje/images/6/6f/28a.jpg/revision/latest/scale-to-width-down/1200?cb=20200812013209&path-prefix=es", "La sirenita", 1989 },
                    { 18, "https://static.wikia.nocookie.net/doblaje/images/1/1c/La_Sirenita_2.jpg/revision/latest?cb=20091112103319&path-prefix=es", "La sirenita 2", 2026 },
                    { 19, "https://m.media-amazon.com/images/M/MV5BYzY2ZjM0NTgtNDc3OS00YmQwLTlkN2YtMmRmMDAxMmM0NTliXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "The silent", 2019 },
                    { 20, "https://m.media-amazon.com/images/S/pv-target-images/450fc3671402b95549e29af286cf9c6c4aa439e2a2399adbde570f2970c6092a._UR2000,3000_.jpg", "Un lugar en silencio dia 1", 2018 },
                    { 21, "https://pics.filmaffinity.com/don_t_say_good_luck-469823819-large.jpg", "No se desea buena suerte", 2026 },
                    { 22, "https://m.media-amazon.com/images/M/MV5BOGJkNjBkNTUtYWM2OC00MDJiLWE0ZjctMmMxMjE1ODMxMzQxXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "La captura", 2026 },
                    { 23, "https://static.wikia.nocookie.net/doblaje/images/e/e9/LaNuevaCenicienta_Poster.png/revision/latest?cb=20190818235855&path-prefix=es", "La nueva cenicienta", 2004 },
                    { 24, "https://m.media-amazon.com/images/M/MV5BMTUwNDAzMzIxOF5BMl5BanBnXkFtZTgwNTU1NzAwNzE@._V1_FMjpg_UX1000_.jpg", "La nueva cenicienta 2", 2008 },
                    { 25, "https://m.media-amazon.com/images/M/MV5BMTAxMGFjODItYTliNy00NjQyLTlkM2MtYWY5YzVmYjk5OGFiXkEyXkFqcGc@._V1_.jpg", "Charlie y la fábrica de chocolate", 2005 },
                    { 26, "https://hips.hearstapps.com/hmg-prod/images/pele-dcumental-netflix-esquire2-1613895136.jpg", "Pelé", 2021 },
                    { 27, "https://m.media-amazon.com/images/M/MV5BMTIwMDQyNjQzNl5BMl5BanBnXkFtZTcwMjEwODI0MQ@@._V1_.jpg", "Una casa patas arriba", 2007 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
