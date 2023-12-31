﻿using Microsoft.EntityFrameworkCore;
using Royex.Application.Context;
using Royex.Application.RepositoryImplementation.EntityRepository;
using Royex.Application.UnitofWork;
using Royex.Domain.RepositoryInterface;
using Royex.Domain.UnitOfWork;
using Royex.Persistance.Context;
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
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
