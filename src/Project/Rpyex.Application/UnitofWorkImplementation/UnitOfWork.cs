using Microsoft.EntityFrameworkCore;
using Royex.Domain.UnitOfWork;

namespace Royex.Application.UnitofWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void  Dispose()
        {
            dbContext.DisposeAsync();
        }

        public async Task SaveChangeAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
