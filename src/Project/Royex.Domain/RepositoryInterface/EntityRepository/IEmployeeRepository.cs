using Royex.Domain.Entity;
using Royex.Domain.Repository;

namespace Royex.Domain.RepositoryInterface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        bool IsLeapYear();
        bool IsStayedFourYears(DateTime joiningDate);
        bool IsEmployeeJoinedBeforeManager(DateTime magerJoingDate, DateTime employeeJoiningDate);
    }
}
