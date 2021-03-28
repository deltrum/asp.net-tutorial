using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Command> Commands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
            .Entity<Platform>()
            .HasMany(p => p.OwnedCommands)
            .WithOne(p => p.Platform)
            .HasForeignKey(p => p.PlatformId);

            modelBuilder
            .Entity<Command>()
            .HasOne(p => p.Platform)
            .WithMany(p => p.OwnedCommands)
            .HasForeignKey(p => p.PlatformId);
        }
    }
}