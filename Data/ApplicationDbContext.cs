using Academic_Administration_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Academic_Administration_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasIndex(s => s.Email)
                .IsUnique();

            modelBuilder.Entity<Faculty>()
                .HasIndex(f => f.Email)
                .IsUnique();
        }
    }
}