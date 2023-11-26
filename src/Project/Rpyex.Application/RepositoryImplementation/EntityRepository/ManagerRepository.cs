using Royex.Domain.Entity;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Royex.Application.Context;

namespace Royex.Application.RepositoryImplementation.EntityRepository
{
    public class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(IApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
