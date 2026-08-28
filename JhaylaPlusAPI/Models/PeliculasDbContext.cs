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
                new Peliculas { Id = 1, Titulo = "Nuestro hilo rojo a distancia", ImagenUrl = "/images/ojitoscute.png", Year = 2024 },
                new Peliculas { Id = 2, Titulo = "Avengers Doomsday", ImagenUrl = "https://m.media-amazon.com/images/M/MV5B...", Year = 2026 },
                new Peliculas { Id = 3, Titulo = "Spiderman", ImagenUrl = "https://assets.cinemark-core.com/5db771be04daec0...", Year = 2021 },
                new Peliculas { Id = 4, Titulo = "It", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ...", Year = 2017 },
                new Peliculas { Id = 5, Titulo = "Moana", ImagenUrl = "https://static.wikia.nocookie.net/disney/images/7/76...", Year = 2016 },
                new Peliculas { Id = 6, Titulo = "Son como niños 2", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images...", Year = 2013 },
                new Peliculas { Id = 7, Titulo = "The last house", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMjI...", Year = 2009 }
            );
        }
    }
}