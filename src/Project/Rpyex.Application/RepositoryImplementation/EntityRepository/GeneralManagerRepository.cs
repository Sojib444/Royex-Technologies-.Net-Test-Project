using Royex.Domain.Entity;
using Royex.Domain.Repository;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Rpyex.Application.Context;

namespace Rpyex.Application.RepositoryImplementation.EntityRepository
{
    public class GeneralManagerRepository : Repository<GeneralManager>, IGeneralManagerRepostory
    {
        public GeneralManagerRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
