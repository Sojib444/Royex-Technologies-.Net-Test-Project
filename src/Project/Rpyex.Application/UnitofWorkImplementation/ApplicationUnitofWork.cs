using Microsoft.EntityFrameworkCore;
using Royex.Application.Context;
using Royex.Application.UnitofWork;
using Royex.Domain.RepositoryInterface;
using Royex.Domain.UnitOfWork;

namespace Rpyex.Application.UnitofWorkImplementation
{
    public class ApplicationUnitofWork : UnitOfWork, IApplicationUnitofWork
    {
        public IEmployeeRepository EmployeeRepository { get; }

        public ApplicationUnitofWork(IApplicationDbContext dbContext,
            IEmployeeRepository employeeRepository) : base((DbContext)dbContext)
        {
            EmployeeRepository = employeeRepository;
        }
    }
}
