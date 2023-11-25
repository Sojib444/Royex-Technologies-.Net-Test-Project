using Microsoft.EntityFrameworkCore;
using Royex.Domain.Entity;

namespace Rpyex.Application.Context
{
    public interface IApplicationDbContext 
    {
        DbSet<Manager> Manager { get; }
        DbSet<GeneralManager> GeneralManager { get; }
        DbSet<OfficeExecutive> OfficeExecutives { get; }
    }
}
