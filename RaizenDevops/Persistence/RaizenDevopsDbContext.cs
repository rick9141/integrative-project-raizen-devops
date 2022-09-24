using Microsoft.EntityFrameworkCore;
using RaizenDevops.Core.Entities;

namespace RaizenDevops.Persistence
{
    public class RaizenDevopsDbContext : DbContext
    {
        public RaizenDevopsDbContext(DbContextOptions<RaizenDevopsDbContext> options) : base(options)
        {
        }

        public DbSet<Fuel> Fuels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fuel>(f =>
            {
                f.HasKey(f => f.Id);
            });
        }
    }
}
