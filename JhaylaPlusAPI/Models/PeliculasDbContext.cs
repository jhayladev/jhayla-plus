using Microsoft.EntityFrameworkCore;

namespace JhaylaPlusAPI.Models
{
    public class PeliculasDbContext : DbContext
    {
        public DbSet<Peliculas> Peliculas { get; set; }

        public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Peliculas>().HasData(
                new Peliculas { Id = 1, Titulo = "Nuestro hilo rojo a distancia", ImagenUrl = "/images/ojitoscute.png", Year = 2026 },
                new Peliculas { Id = 2, Titulo = "Avengers Doomsday", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BNGEwYWZkN2UtOTQ5Mi00MGQzLWEzNjYtMWMyNDBkMTkzMWNkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2026 },
                new Peliculas { Id = 3, Titulo = "Spiderman", ImagenUrl = "https://assets.cinemark-core.com/5db771be04daec00076df3f5/vista/movies/6a22d1b9720d1d2a7f8d9a19/common/spiderman-nuevo-dia-109320-1780678232870", Year = 2026 },
                new Peliculas { Id = 4, Titulo = "It", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkmVRJ71XkUcnm_DAc2_d4_Iw9oX6bqu9lIY4Zz9a9ZlLOCDINM4dnX0zj&s=10", Year = 2017 },
                new Peliculas { Id = 5, Titulo = "Moana", ImagenUrl = "https://static.wikia.nocookie.net/disney/images/7/76/Moana_official_poster.jpg/revision/latest?cb=20160921035605&path-prefix=es", Year = 2016 },
                new Peliculas { Id = 6, Titulo = "Son como niños 2", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7zjfqxpuf0AHiQ-y2EvPuNku-JVcGZH2-_puckCF_sRdwbiKGdeF2tcqs&s=10", Year = 2013 },
                new Peliculas { Id = 7, Titulo = "The last house", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMjI5YTQ3YmItZjk1ZS00ZDBmLWJhZDMtNThhMDI5ZTRkMTcxXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2026 },
                new Peliculas { Id = 8, Titulo = "Un chihuahua en Beverly Hills", ImagenUrl = "https://es.web.img2.acsta.net/medias/nmedia/18/68/79/58/19045139.jpg", Year = 2008 },
                new Peliculas { Id = 9, Titulo = "Cenicienta", ImagenUrl = "https://es.web.img2.acsta.net/pictures/14/11/19/16/01/398307.jpg", Year = 2015 },
                new Peliculas { Id = 10, Titulo = "Rapunzel", ImagenUrl = "https://es.web.img3.acsta.net/medias/nmedia/18/79/96/30/19541005.jpg", Year = 2010 },
                new Peliculas { Id = 11, Titulo = "Cars: Una aventura sobre ruedas", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMTg5NzY0MzA2MV5BMl5BanBnXkFtZTYwNDc3NTc2._V1_FMjpg_UX1000_.jpg", Year = 2006 },
                new Peliculas { Id = 12, Titulo = "Toy Story", ImagenUrl = "https://es.web.img3.acsta.net/pictures/14/03/17/10/20/509771.jpg", Year = 1995 },
                new Peliculas { Id = 13, Titulo = "La bella y la bestia", ImagenUrl = "https://es.web.img3.acsta.net/pictures/17/01/09/09/56/256507.jpg", Year = 2017 },
                new Peliculas { Id = 14, Titulo = "La princesa y el sapo", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BOTE3YTExYTEtOTUxZC00OTM0LWJmYmItMDk5YjczNmIwNzA2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2009 },
                new Peliculas { Id = 15, Titulo = "Malefica", ImagenUrl = "https://es.web.img3.acsta.net/pictures/14/03/11/09/33/450247.jpg", Year = 2014 },
                new Peliculas { Id = 16, Titulo = "Malefica 2", ImagenUrl = "https://static.wikia.nocookie.net/doblaje/images/5/56/MLFCDMCartel.jpg/revision/latest?cb=20190927034818&path-prefix=es", Year = 2019 },
                new Peliculas { Id = 17, Titulo = "La sirenita", ImagenUrl = "https://static.wikia.nocookie.net/doblaje/images/6/6f/28a.jpg/revision/latest/scale-to-width-down/1200?cb=20200812013209&path-prefix=es", Year = 1989 },
                new Peliculas { Id = 18, Titulo = "La sirenita 2", ImagenUrl = "https://static.wikia.nocookie.net/doblaje/images/1/1c/La_Sirenita_2.jpg/revision/latest?cb=20091112103319&path-prefix=es", Year = 2026 },
                new Peliculas { Id = 19, Titulo = "The silent", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BYzY2ZjM0NTgtNDc3OS00YmQwLTlkN2YtMmRmMDAxMmM0NTliXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2019 },
                new Peliculas { Id = 20, Titulo = "Un lugar en silencio dia 1", ImagenUrl = "https://m.media-amazon.com/images/S/pv-target-images/450fc3671402b95549e29af286cf9c6c4aa439e2a2399adbde570f2970c6092a._UR2000,3000_.jpg", Year = 2018 },
                new Peliculas { Id = 21, Titulo = "No se desea buena suerte", ImagenUrl = "https://pics.filmaffinity.com/don_t_say_good_luck-469823819-large.jpg", Year = 2026 },
                new Peliculas { Id = 22, Titulo = "La captura", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BOGJkNjBkNTUtYWM2OC00MDJiLWE0ZjctMmMxMjE1ODMxMzQxXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2026 },
                new Peliculas { Id = 23, Titulo = "La nueva cenicienta", ImagenUrl = "https://static.wikia.nocookie.net/doblaje/images/e/e9/LaNuevaCenicienta_Poster.png/revision/latest?cb=20190818235855&path-prefix=es", Year = 2004 },
                new Peliculas { Id = 24, Titulo = "La nueva cenicienta 2", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMTUwNDAzMzIxOF5BMl5BanBnXkFtZTgwNTU1NzAwNzE@._V1_FMjpg_UX1000_.jpg", Year = 2008 },
                new Peliculas { Id = 25, Titulo = "Charlie y la fábrica de chocolate", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMTAxMGFjODItYTliNy00NjQyLTlkM2MtYWY5YzVmYjk5OGFiXkEyXkFqcGc@._V1_.jpg", Year = 2005 },
                new Peliculas { Id = 26, Titulo = "Pelé", ImagenUrl = "https://hips.hearstapps.com/hmg-prod/images/pele-dcumental-netflix-esquire2-1613895136.jpg", Year = 2021 },
                new Peliculas { Id = 27, Titulo = "Una casa patas arriba", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMTIwMDQyNjQzNl5BMl5BanBnXkFtZTcwMjEwODI0MQ@@._V1_.jpg", Year = 2007 }
            );
        }
    }
}