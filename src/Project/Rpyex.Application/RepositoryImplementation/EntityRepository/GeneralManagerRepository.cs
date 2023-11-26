using Royex.Domain.Entity;
using Royex.Domain.Repository;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Royex.Application.Context;

namespace Royex.Application.RepositoryImplementation.EntityRepository
{
    public class GeneralManagerRepository : Repository<GeneralManager>, IGeneralManagerRepostory
    {
        public GeneralManagerRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
