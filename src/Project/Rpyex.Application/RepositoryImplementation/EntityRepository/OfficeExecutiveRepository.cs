using Royex.Domain.Entity;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Royex.Application.Context;

namespace Royex.Application.RepositoryImplementation.EntityRepository
{
    public class OfficeExecutiveRepository : Repository<OfficeExecutive>, IOfficeExecutiveRepository
    {
        public OfficeExecutiveRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
