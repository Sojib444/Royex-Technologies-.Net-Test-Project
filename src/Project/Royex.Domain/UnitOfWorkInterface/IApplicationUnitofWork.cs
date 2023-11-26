using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;

namespace Royex.Domain.UnitOfWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
         IManagerRepository ManagerRepository { get; }
         IGeneralManagerRepostory GeneralManagerRepostory { get; }
         IOfficeExecutiveRepository GfficeExecutiveRepository { get;}
}
