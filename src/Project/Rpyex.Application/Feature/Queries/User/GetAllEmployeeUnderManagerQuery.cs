using MediatR;
using Royex.Application.Dto;

namespace Royex.Application.Feature.Queries.User
{
    public record GetAllEmployeeUnderManagerQuery(int id, bool trackChange,CancellationToken cancellationToken) : IRequest<IEnumerable<EmployeeDto>>;
}
