using Microsoft.EntityFrameworkCore;
using Royex.Domain.Entity;

namespace Royex.Application.Context
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<TEntity> DbSet<TEntity>() where TEntity : class;
        DbSet<Manager> Manager { get; }
        DbSet<GeneralManager> GeneralManager { get; }
        DbSet<OfficeExecutive> OfficeExecutives { get; }
    }
}
