using Microsoft.EntityFrameworkCore;

namespace JhaylaPlusAPI.Models
{
    public class UsuariosDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuarios>().HasData(

                new Usuarios { Id = 1, Nombre = "Addu", Apellido = "Nuñez", Correo = "addununeznunezavila@gmail.com", Contraseña = "1234" },
                new Usuarios { Id = 2, Nombre = "Luis", Apellido = "Frias", Correo = "luis.frias@gmail.com", Contraseña = "1234" },
                new Usuarios { Id = 3, Nombre = "Andres", Apellido = "Rincones", Correo = "andres.rincones@gmail.com", Contraseña = "1234" },
                new Usuarios { Id = 4, Nombre = "Rafael", Apellido = "Florez", Correo = "rafael.florez@gmail.com", Contraseña = "1234" }

            );
        }


    }
}
