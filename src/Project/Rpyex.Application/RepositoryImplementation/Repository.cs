using Microsoft.EntityFrameworkCore;
using Royex.Application.Context;
using Royex.Domain.Repository;
using System.Linq.Expressions;

namespace Royex.Application.RepositoryImplementation
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

        //Get All Employee by Condition
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, 
            bool trackChange, CancellationToken cancellationToken)
        {
            return !trackChange ? await dbSet.AsNoTracking().Where(expression).ToListAsync(cancellationToken) :
                await dbSet.AsTracking().Where(expression).ToListAsync(cancellationToken);
        }

        //Get Single Employee
        public async Task<T> GetSingleAsync(int id, CancellationToken cancellationToken)
        {
            return await dbSet.FindAsync(id, cancellationToken);
        }
    }
}
