using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VoetbalApp.Models;

namespace VoetbalApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>()
                .HasOne(e => e.Team)
                .WithMany(e => e.Players)
                .HasForeignKey(e => e.TeamId)
                .IsRequired(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithOne(e => e.Team)
                .HasForeignKey(e => e.TeamId)
                .IsRequired(false);

        }
    }
}