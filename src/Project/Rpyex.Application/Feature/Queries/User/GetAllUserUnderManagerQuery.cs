using MediatR;
using Royex.Application.Dto;

namespace Royex.Application.Feature.Queries.User
{
    public record GetAllUserUnderManagerQuery(bool trackChange) : IRequest<IEnumerable<UserDto>>;
}
