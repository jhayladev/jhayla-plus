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

        }
    }
}