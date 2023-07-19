using CE.ApiDotnet7.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CE.ApiDotnet7.Infra.Data.Context
{
    public class CeContext : DbContext
    {
        public CeContext(DbContextOptions<CeContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CeContext).Assembly);
        }
    }
}
