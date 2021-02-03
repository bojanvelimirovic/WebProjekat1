using Microsoft.EntityFrameworkCore;

namespace Server.Models
{


    public class AvionContext : DbContext
    {
        public DbSet<Avion> Avioni {get; set;}
        public DbSet<Lokacija> Lokacije {get; set;}


        public AvionContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avion>()
                .HasMany(s => s.Lokacije)
                .WithOne(s => s.Avion)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }



    }


}