using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JhaylaPlusAPI.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarPeliculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://es.web.img2.acsta.net/medias/nmedia/18/68/79/58/19045139.jpg", "Un chihuahua en Beverly Hills", 2008 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://es.web.img2.acsta.net/pictures/14/11/19/16/01/398307.jpg", "Cenicienta", 2015 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://es.web.img3.acsta.net/medias/nmedia/18/79/96/30/19541005.jpg", "Rapunzel", 2010 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTg5NzY0MzA2MV5BMl5BanBnXkFtZTYwNDc3NTc2._V1_FMjpg_UX1000_.jpg", "Cars: Una aventura sobre ruedas", 2006 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://es.web.img3.acsta.net/pictures/14/03/17/10/20/509771.jpg", "Toy Story", 1995 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://es.web.img3.acsta.net/pictures/17/01/09/09/56/256507.jpg", "La bella y la bestia", 2017 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BOTE3YTExYTEtOTUxZC00OTM0LWJmYmItMDk5YjczNmIwNzA2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "La princesa y el sapo", 2009 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://es.web.img3.acsta.net/pictures/14/03/11/09/33/450247.jpg", "Malefica", 2014 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://static.wikia.nocookie.net/doblaje/images/5/56/MLFCDMCartel.jpg/revision/latest?cb=20190927034818&path-prefix=es", "Malefica 2", 2019 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://static.wikia.nocookie.net/doblaje/images/6/6f/28a.jpg/revision/latest/scale-to-width-down/1200?cb=20200812013209&path-prefix=es", "La sirenita", 1989 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImagenUrl", "Titulo" },
                values: new object[] { "https://static.wikia.nocookie.net/doblaje/images/1/1c/La_Sirenita_2.jpg/revision/latest?cb=20091112103319&path-prefix=es", "La sirenita 2" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BYzY2ZjM0NTgtNDc3OS00YmQwLTlkN2YtMmRmMDAxMmM0NTliXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "The silent", 2019 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/S/pv-target-images/450fc3671402b95549e29af286cf9c6c4aa439e2a2399adbde570f2970c6092a._UR2000,3000_.jpg", "Un lugar en silencio dia 1", 2018 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImagenUrl", "Titulo" },
                values: new object[] { "https://pics.filmaffinity.com/don_t_say_good_luck-469823819-large.jpg", "No se desea buena suerte" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImagenUrl", "Titulo" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BOGJkNjBkNTUtYWM2OC00MDJiLWE0ZjctMmMxMjE1ODMxMzQxXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", "La captura" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://static.wikia.nocookie.net/doblaje/images/e/e9/LaNuevaCenicienta_Poster.png/revision/latest?cb=20190818235855&path-prefix=es", "La nueva cenicienta", 2004 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTUwNDAzMzIxOF5BMl5BanBnXkFtZTgwNTU1NzAwNzE@._V1_FMjpg_UX1000_.jpg", "La nueva cenicienta 2", 2008 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTAxMGFjODItYTliNy00NjQyLTlkM2MtYWY5YzVmYjk5OGFiXkEyXkFqcGc@._V1_.jpg", "Charlie y la fábrica de chocolate", 2005 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://hips.hearstapps.com/hmg-prod/images/pele-dcumental-netflix-esquire2-1613895136.jpg", "Pelé", 2021 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTIwMDQyNjQzNl5BMl5BanBnXkFtZTcwMjEwODI0MQ@@._V1_.jpg", "Una casa patas arriba", 2007 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+08", "Pelicula placeholder 08", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+09", "Pelicula placeholder 09", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+10", "Pelicula placeholder 10", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+11", "Pelicula placeholder 11", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+12", "Pelicula placeholder 12", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+13", "Pelicula placeholder 13", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+14", "Pelicula placeholder 14", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+15", "Pelicula placeholder 15", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+16", "Pelicula placeholder 16", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+17", "Pelicula placeholder 17", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImagenUrl", "Titulo" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+18", "Pelicula placeholder 18" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+19", "Pelicula placeholder 19", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+20", "Pelicula placeholder 20", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImagenUrl", "Titulo" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+21", "Pelicula placeholder 21" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImagenUrl", "Titulo" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+22", "Pelicula placeholder 22" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+23", "Pelicula placeholder 23", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+24", "Pelicula placeholder 24", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+25", "Pelicula placeholder 25", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+26", "Pelicula placeholder 26", 2026 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImagenUrl", "Titulo", "Year" },
                values: new object[] { "https://placehold.co/400x600/141824/1cd2e5?text=Pelicula+27", "Pelicula placeholder 27", 2026 });
        }
    }
}
