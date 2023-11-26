using MediatR;
using Royex.Application.Dto;
using Royex.Domain.UnitOfWork;

namespace Royex.Application.Feature.Queries.User
{
    public class GetAllUserUnderManagerQueryHandler : 
        IRequestHandler<GetAllUserUnderManagerQuery, IEnumerable<UserDto>>
    {
        private readonly IApplicationUnitofWork applicationUnitofWork;

        public GetAllUserUnderManagerQueryHandler(IApplicationUnitofWork applicationUnitofWork)
        {
            this.applicationUnitofWork = applicationUnitofWork;
        }

        public Task<IEnumerable<UserDto>> Handle(GetAllUserUnderManagerQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
