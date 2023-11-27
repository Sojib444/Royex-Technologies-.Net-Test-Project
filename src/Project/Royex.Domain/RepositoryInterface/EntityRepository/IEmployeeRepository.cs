using Royex.Domain.Entity;
using Royex.Domain.Repository;

namespace Royex.Domain.RepositoryInterface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        bool IsLeapYear();
        bool IsStayedFourYears(DateTime joiningDate);
        bool IsManagerJoinedBerforImidiateManager(DateTime magerJoingDate, DateTime imidiateManagerJoiningDate);
        Employee ImidiateManager(IEnumerable<Employee> employees,Employee employee);
    }
}
