namespace JhaylaPlusAPI.Models
{
    // Relación simple Usuario <-> Película guardada en "Mi Lista".
    // Vive en la misma base de datos que Usuarios (UsuariosDbContext) y
    // guarda solo los IDs: no se referencia la tabla Peliculas de forma
    // relacional en EF porque pertenece a otro DbContext (PeliculasDbContext).
    public class Favorito
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PeliculaId { get; set; }
        public DateTime FechaAgregado { get; set; } = DateTime.UtcNow;
    }
}
