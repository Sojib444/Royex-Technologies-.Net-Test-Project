using Royex.Domain.RepositoryInterface;

namespace Royex.Domain.UnitOfWork
{
    public interface IApplicationUnitofWork : IUnitofWork
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}
