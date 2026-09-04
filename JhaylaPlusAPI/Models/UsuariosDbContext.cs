using Microsoft.EntityFrameworkCore;

namespace JhaylaPlusAPI.Models
{
    public class UsuariosDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }

        public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Un usuario no puede tener la misma película repetida en su lista.
            modelBuilder.Entity<Favorito>()
                .HasIndex(f => new { f.UsuarioId, f.PeliculaId })
                .IsUnique();

            modelBuilder.Entity<Usuarios>().HasData(

                new Usuarios { Id = 1, Nombre = "Addu", Apellido = "Nuñez", Correo = "addununeznunezavila@gmail.com", Contraseña = "1234" },
                new Usuarios { Id = 2, Nombre = "Luis", Apellido = "Frias", Correo = "luis.frias@gmail.com", Contraseña = "1234" },
                new Usuarios { Id = 3, Nombre = "Andres", Apellido = "Rincones", Correo = "andres.rincones@gmail.com", Contraseña = "1234" },
                new Usuarios { Id = 4, Nombre = "Rafael", Apellido = "Florez", Correo = "rafael.florez@gmail.com", Contraseña = "1234" }

            );
        }


    }
}
