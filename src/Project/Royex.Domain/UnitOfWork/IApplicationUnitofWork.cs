using Royex.Domain.Repository.GeneralManagerRepository;
using Royex.Domain.Repository.ManagerRepository;
using Royex.Domain.Repository.OfficeExecutiveRepository;

namespace Royex.Domain.UnitOfWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
        IGeneralManagerRepostory GetGeneralManagerRepostory { get; }
        IManagerRepository ManagerRepository { get; }
        IOfficeExecutiveRepository OfficeExecutiveRepository { get; }
    }
}
