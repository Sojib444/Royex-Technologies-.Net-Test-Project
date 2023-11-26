using Royex.Domain.UnitOfWork;
using Royex.Persistance.Context;
using Rpyex.Application.Context;
using Rpyex.Application.UnitofWork;
using Rpyex.Application.UnitofWorkImplementation;

namespace Royex.Presentation.Service_Extension
{
    public static class DependencyService
    {
        public static void DependencyServiceConfiguration(this IServiceCollection services)
        {
            //DbContext
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            //UnitofWork
            services.AddScoped<IUnitofWork, UnitOfWork>();
            services.AddScoped<IApplicationUnitofWork, ApplicationUnitofWork>();

            //Repository
            
        }
    }
}
