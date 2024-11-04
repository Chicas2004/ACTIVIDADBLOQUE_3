using Microsoft.EntityFrameworkCore;
namespace ACTIVIDADBLOQUE_3.Models
{

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Pelicula> peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(Pelicula => Pelicula.idPelicula);
        }
    }

}