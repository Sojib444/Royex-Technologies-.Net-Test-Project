using Mapster;
using MediatR;
using Royex.Application.Dto;
using Royex.Domain.UnitOfWork;
using Royex.Domain.Entity.Shared;

namespace Royex.Application.Feature.Queries.User
{
    public class GetAllEmployeeUnderManagerQueryHandler : 
        IRequestHandler<GetAllEmployeeUnderManagerQuery, IEnumerable<EmployeeDto>>
    {
        private readonly IApplicationUnitofWork applicationUnitofWork;

        public GetAllEmployeeUnderManagerQueryHandler(IApplicationUnitofWork applicationUnitofWork)
        {
            this.applicationUnitofWork = applicationUnitofWork;
        }

        public async Task<IEnumerable<EmployeeDto>> Handle(GetAllEmployeeUnderManagerQuery request,
            CancellationToken cancellationToken)
        {
            //Find the employee Exist or Not
            var employee = applicationUnitofWork.EmployeeRepository
                    .GetSingleAsync(request.id, cancellationToken).Result;

            if(employee != null)
            {
                //Get the Found Employee Position
                int foundEmployeePosition = (int) employee.Position;

                //Get employee according to the found employee chain rule.
                var allChainEmployee = await applicationUnitofWork.EmployeeRepository.GetAllAsync(x => 
                    (int)x.Position <= foundEmployeePosition,request.trackChange, cancellationToken);

                foreach(var item in allChainEmployee)
                {
                    if (item.Position == Position.Manager)
                    {
                        // Get Root Manager joining date 
                        var managerJoiningDate = item.JoiningDate;

                        //Get Emidiate Manager
                        var getEmidiateJoiningManager = applicationUnitofWork.EmployeeRepository.ImidiateManager(allChainEmployee, item);

                        //Check Imidiate Manager has or hasn't
                        bool hasImidiatemanger = false;

                        if(getEmidiateJoiningManager != null)
                        {
                            //Check the manager joined before its imidiate manager or not
                            hasImidiatemanger = applicationUnitofWork.EmployeeRepository
                              .IsManagerJoinedBerforImidiateManager(managerJoiningDate,getEmidiateJoiningManager.JoiningDate);
                        }

                        //check Root Manager staying 4 years or not and current year is leap year 
                        var isFourYears = applicationUnitofWork.EmployeeRepository.IsStayedFourYears(managerJoiningDate);
                        var isLeapYear = applicationUnitofWork.EmployeeRepository.IsLeapYear();

                        //According to salary with Bonus calculation Logic
                        if (isFourYears && isLeapYear)
                        {
                            item.Salary += 10000 * 1000;

                            if(hasImidiatemanger)
                            {
                                item.Salary += 2000 + 10000;
                            }
                        }
                        else if (isFourYears && !isLeapYear)
                        {
                            item.Salary += 8000 * 1000;

                            if (!hasImidiatemanger)
                            {
                                item.Salary += 1000 + 8000;
                            }
                        }
                        else if (!isFourYears && isLeapYear)
                        {
                            item.Salary += 5000 * 1000;

                            if (hasImidiatemanger)
                            {
                                item.Salary += 1000 + 5000;
                            }
                        }
                        else if (!isFourYears && !isLeapYear)
                        {
                            item.Salary += 3000 * 1000;

                            if (!hasImidiatemanger)
                            {
                                item.Salary += 5000 + 3000;
                            }
                        }
                    }
                }  
                
                //Mapping All Chain Employee With Dto
                List<EmployeeDto> employeeDto = allChainEmployee.Adapt<List<EmployeeDto>>();                              

                return employeeDto;                    
            }
            else
                return null;
        }
    }
}
