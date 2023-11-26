using Microsoft.EntityFrameworkCore;
using Royex.Domain.Entity;
using Royex.Persistance.Context.Configuration;
using Rpyex.Application.Context;

namespace Royex.Persistance.Context
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new GeneralManagerConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeExecutiveConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TEntity> DbSet<TEntity>() where TEntity : class => Set<TEntity>();

        public DbSet<Manager> Manager { get; }

        public DbSet<GeneralManager> GeneralManager { get; }

        public DbSet<OfficeExecutive> OfficeExecutives { get; }
    }
}
