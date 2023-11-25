using Microsoft.EntityFrameworkCore;
using Royex.Domain.UnitOfWork;

namespace Rpyex.Application.UnitofWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly DbContext dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Dispose()
        {
            await dbContext.DisposeAsync();
        }

        public async Task SaveChangeAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
