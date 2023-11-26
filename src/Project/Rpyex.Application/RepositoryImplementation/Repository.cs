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
        public Task<IEnumerable<T>> GetAllAsync(bool trackChange, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(int id, bool trackChange, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
