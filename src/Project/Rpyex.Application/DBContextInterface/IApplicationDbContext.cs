using Microsoft.EntityFrameworkCore;
using Royex.Domain.Entity;

namespace Royex.Application.Context
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<TEntity> DbSet<TEntity>() where TEntity : class;
        DbSet<Employee> Employees { get; }
    }
}
