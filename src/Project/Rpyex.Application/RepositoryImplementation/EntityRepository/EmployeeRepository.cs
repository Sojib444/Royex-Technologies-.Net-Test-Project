using Royex.Application.Context;
using Royex.Domain.Entity;
using Royex.Domain.RepositoryInterface;
using Royex.Domain.UnitOfWork;

namespace Royex.Application.RepositoryImplementation.EntityRepository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly IApplicationUnitofWork unitofWork;

        public EmployeeRepository(IApplicationDbContext dbContext, IApplicationUnitofWork unitofWork) : base(dbContext)
        {
            this.unitofWork = unitofWork;
        }

        public async Task<bool> IsEmployeeJoinedBeforeManager(DateTime magerJoingDate, DateTime employeeJoiningDate)
        {
            TimeSpan managerTimeSpan = DateTime.Now - magerJoingDate;
            TimeSpan employeeTimeSpan = DateTime.Now - magerJoingDate;

            return employeeTimeSpan.Days >= managerTimeSpan.Days ? true : false;
        }

        public async Task<bool> IsLeapYear()
        {
            int curruntYear = DateTime.Now.Year;

            return ((curruntYear % 4 == 0 && curruntYear % 100 != 0) || curruntYear % 400 ==0 ) ? true : false;
        }

        public async Task<bool> IsStayedFourYears(DateTime joiningDate)
        {
            TimeSpan timeSpan = DateTime.Now - joiningDate;

            return timeSpan.Days / 365 >= 4 ? true : false;
        }
    }
}
