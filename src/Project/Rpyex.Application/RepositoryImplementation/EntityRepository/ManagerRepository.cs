using Royex.Domain.Entity;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Rpyex.Application.Context;

namespace Rpyex.Application.RepositoryImplementation.EntityRepository
{
    public class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(IApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
