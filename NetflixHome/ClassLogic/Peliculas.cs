namespace NetflixHome.ClassLogic
{
    public class Peliculas
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? ImagenUrl { get; set; }
        public int Year { get; set; }

        // Datos ampliados para la ficha de detalle de la película.
        public string? Sinopsis { get; set; }
        public string? Duracion { get; set; }
        public string? Director { get; set; }
        public string? Genero { get; set; }
        public string? Reparto { get; set; }
        public string? Clasificacion { get; set; }
        public string? Formatos { get; set; }
        public string? Etiqueta { get; set; }
    }
}
