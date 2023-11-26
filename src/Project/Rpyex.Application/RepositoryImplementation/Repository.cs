using Microsoft.EntityFrameworkCore;
using Royex.Domain.Repository;
using Rpyex.Application.Context;

namespace Rpyex.Application.RepositoryImplementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IApplicationDbContext applicationDbContext;
        private DbSet<T> dbSet;
        public Repository(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            dbSet = this.applicationDbContext.DbSet<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync(bool trackChange, CancellationToken cancellationToken)
        {
            return !trackChange ? await dbSet.AsNoTracking().ToListAsync(cancellationToken) :
               await dbSet.ToListAsync(cancellationToken);
        }

        public async Task<T> GetSingleAsync(int id, bool trackChange, CancellationToken cancellationToken)
        {
               return !trackChange ? await dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Equals(id),cancellationToken) :
                 await dbSet.FirstOrDefaultAsync(x => x.Equals(id), cancellationToken);
        }
    }
}
