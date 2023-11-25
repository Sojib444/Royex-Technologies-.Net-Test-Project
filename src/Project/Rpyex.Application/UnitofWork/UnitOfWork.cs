using Royex.Domain.UnitOfWork;
using Rpyex.Application.Context;

namespace Rpyex.Application.UnitofWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly IApplicationDbContext dbContext;

        public UnitOfWork(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }

        public async Task SaveChangeAsync()
        {
            await dbContext.SaveChage();
        }
    }
}
