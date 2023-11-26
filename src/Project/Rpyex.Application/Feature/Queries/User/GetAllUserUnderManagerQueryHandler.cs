using Mapster;
using MediatR;
using Royex.Application.Dto;
using Royex.Domain.UnitOfWork;

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
                var employee = applicationUnitofWork.EmployeeRepository
                      .GetAllAsync(request.trackChange, request.cancellationToken).Result;

                if(employee != null)
                {
                    List<EmployeeDto> employeeDto = employee.Adapt<List<EmployeeDto>>();
                    Console.WriteLine(employeeDto);
                }

            return null;
        }
    }
}
