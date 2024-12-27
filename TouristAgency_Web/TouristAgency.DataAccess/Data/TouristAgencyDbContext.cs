using Microsoft.EntityFrameworkCore;
using TouristAgency.Models;


namespace TouristAgency.DataAccess.Data
{
    public class TouristAgencyDbContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; } = null!;
        public DbSet<Orders> Orders { get; set; } = null!;
        public DbSet<Excursions> Excursions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .HasOne<Clients>()
                .WithMany()
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Orders>()
                .HasOne<Excursions>()
                .WithMany()
                .HasForeignKey(e => e.ExcursionId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TouristAgency;Trusted_Connection=True;TrustServerCertificate=True;"); ;
        }
    }
}
