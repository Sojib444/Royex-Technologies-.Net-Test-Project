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

        public Employee ImidiateManager(IEnumerable<Employee> employees, Employee manager)
        {
            int minday = int.MaxValue;
            var emidiateManager = new Employee();

            foreach(var item  in employees)
            {
                if(((int)item.Position) == 1)
                {
                    var imediateJoininingTotalDay = (DateTime.Now - item.JoiningDate).Days;
                    var managerJoininngTotalDay = (DateTime.Now - manager.JoiningDate).Days;

                    var totalDayDiffernce = Math.Abs(imediateJoininingTotalDay - managerJoininngTotalDay);

                    if(totalDayDiffernce < minday )
                    {
                        minday = totalDayDiffernce;
                        emidiateManager = item;
                    }
                }
            }

            return emidiateManager;
        }

        public bool IsManagerJoinedBerforImidiateManager(DateTime magerJoingDate, DateTime imidiateManagerJoiningDate)
        {
            TimeSpan managerTimeSpan = DateTime.Now - magerJoingDate;
            TimeSpan imidiateManagerTimeSpan = DateTime.Now - imidiateManagerJoiningDate;

            return imidiateManagerTimeSpan.Days < managerTimeSpan.Days ? true : false;
        }

        public bool IsLeapYear()
        {
            int curruntYear = DateTime.Now.Year;

            return ((curruntYear % 4 == 0 && curruntYear % 100 != 0) || curruntYear % 400 == 0) ? true : false;
        }

        public bool IsStayedFourYears(DateTime joiningDate)
        {
            TimeSpan timeSpan = DateTime.Now - joiningDate;

            return timeSpan.Days / 365 >= 4 ? true : false;
        }
    }
}
