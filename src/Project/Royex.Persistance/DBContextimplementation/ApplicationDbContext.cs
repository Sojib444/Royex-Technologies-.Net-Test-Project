using Microsoft.EntityFrameworkCore;
using Royex.Domain.Entity;
using Rpyex.Application.Context;

namespace Royex.Persistance.Context
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<TEntity> DbSet<TEntity>() where TEntity : class => Set<TEntity>();

        public DbSet<Manager> Manager { get; }

        public DbSet<GeneralManager> GeneralManager { get; }

        public DbSet<OfficeExecutive> OfficeExecutives { get; }
    }
}
