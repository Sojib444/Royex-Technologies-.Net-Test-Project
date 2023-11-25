using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;

namespace Royex.Domain.UnitOfWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
        IGeneralManagerRepostory GetGeneralManagerRepostory { get; }
        IManagerRepository ManagerRepository { get; }
        IOfficeExecutiveRepository OfficeExecutiveRepository { get; }
    }
}
