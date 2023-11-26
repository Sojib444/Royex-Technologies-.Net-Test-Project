using Microsoft.EntityFrameworkCore;
using Royex.Domain.RepositoryInterface.EntityRepositoryInterface;
using Royex.Domain.UnitOfWork;
using Royex.Persistance.Context;
using Rpyex.Application.Context;
using Rpyex.Application.RepositoryImplementation;
using Rpyex.Application.RepositoryImplementation.EntityRepository;
using Rpyex.Application.UnitofWork;
using Rpyex.Application.UnitofWorkImplementation;

namespace Royex.Presentation.Service_Extension
{
    public static class DependencyService
    {
        public static void DependencyServiceConfiguration(this IServiceCollection services)
        {
            //DbContext
            services.AddScoped<DbContext>();
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            //UnitofWork
            services.AddScoped<IUnitofWork, UnitOfWork>();
            services.AddScoped<IApplicationUnitofWork, ApplicationUnitofWork>();

            //Repository
            services.AddScoped<IManagerRepository,ManagerRepository>();
            services.AddScoped<IGeneralManagerRepostory,GeneralManagerRepository>();
            services.AddScoped<IOfficeExecutiveRepository,OfficeExecutiveRepository>();
        }
    }
}
