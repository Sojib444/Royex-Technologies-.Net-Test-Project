using Royex.Persistance.Context;
using Rpyex.Application.Context;

namespace Royex.Presentation.Service_Extension
{
    public static class DependencyService
    {
        public static void DependencyServiceConfiguration(this IServiceCollection services)
        {
            //DbContext
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            //UnitofWork
            services
        }
    }
}
