using Royex.Application.Context;
using Royex.Domain.Entity;
using Royex.Domain.RepositoryInterface;

namespace Royex.Application.RepositoryImplementation.EntityRepository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
