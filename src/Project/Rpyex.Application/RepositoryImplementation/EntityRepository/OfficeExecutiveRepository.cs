using Royex.Domain.Entity;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Rpyex.Application.Context;

namespace Rpyex.Application.RepositoryImplementation.EntityRepository
{
    public class OfficeExecutiveRepository : Repository<OfficeExecutive>, IOfficeExecutiveRepository
    {
        public OfficeExecutiveRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
