namespace NetflixHome.ClassLogic
{
    /// <summary>
    /// Fuente única de datos de películas.
    /// Se centraliza aquí para que tanto el banner (Carrusel) como las filas
    /// de tarjetas (ListaPeliculas) usen exactamente las mismas películas,
    /// imágenes y rutas.
    /// </summary>
    public static class PeliculasRepository
    {
        public static List<Pelicula> Todas { get; } = new List<Pelicula>
        {
            new Pelicula { Titulo = "Nuestro hilo rojo a distancia", ImagenUrl = "/images/ojitoscute.png", Year = 2026 },
            new Pelicula { Titulo = "Avengers Doomsdah", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BNGEwYWZkN2UtOTQ5Mi00MGQzLWEzNjYtMWMyNDBkMTkzMWNkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2026 },
            new Pelicula { Titulo = "Spiderman", ImagenUrl = "https://assets.cinemark-core.com/5db771be04daec00076df3f5/vista/movies/6a22d1b9720d1d2a7f8d9a19/common/spiderman-nuevo-dia-109320-1780678232870", Year = 2026 },
            new Pelicula { Titulo = "It", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkmVRJ71XkUcnm_DAc2_d4_Iw9oX6bqu9lIY4Zz9a9ZlLOCDINM4dnX0zj&s=10", Year = 2017 },
            new Pelicula { Titulo = "Moana", ImagenUrl = "https://static.wikia.nocookie.net/disney/images/7/76/Moana_official_poster.jpg/revision/latest?cb=20160921035605&path-prefix=es", Year = 2016 },
            new Pelicula { Titulo = "Son como niños 2", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7zjfqxpuf0AHiQ-y2EvPuNku-JVcGZH2-_puckCF_sRdwbiKGdeF2tcqs&s=10", Year = 2013 },
            new Pelicula { Titulo = "The last house", ImagenUrl = "https://m.media-amazon.com/images/M/MV5BMjI5YTQ3YmItZjk1ZS00ZDBmLWJhZDMtNThhMDI5ZTRkMTcxXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg", Year = 2026 }
        };

        /// <summary>
        /// Película destacada usada como imagen grande del banner (hero) de la home.
        /// </summary>
        public static Pelicula Destacada => Todas[1];
    }
}
