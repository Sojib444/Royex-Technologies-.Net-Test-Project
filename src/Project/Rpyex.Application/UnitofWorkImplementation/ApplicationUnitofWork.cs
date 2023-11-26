using Microsoft.EntityFrameworkCore;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Royex.Domain.UnitOfWork;
using Royex.Application.Context;
using Royex.Application.UnitofWork;

namespace Rpyex.Application.UnitofWorkImplementation
{
    public class ApplicationUnitofWork : UnitOfWork,IApplicationUnitofWork
    {
        public IManagerRepository ManagerRepository { get; }
        public IGeneralManagerRepostory GeneralManagerRepostory { get; }
        public IOfficeExecutiveRepository GfficeExecutiveRepository { get; }

        public ApplicationUnitofWork(IApplicationDbContext dbContext, 
            IManagerRepository managerRepository, 
            IGeneralManagerRepostory generalManagerRepostory,
            IOfficeExecutiveRepository officeExecutiveRepository) : base((DbContext)dbContext)
        {
            ManagerRepository = managerRepository;
            GeneralManagerRepostory = generalManagerRepostory;
            GfficeExecutiveRepository = officeExecutiveRepository;
        }
    }
}
