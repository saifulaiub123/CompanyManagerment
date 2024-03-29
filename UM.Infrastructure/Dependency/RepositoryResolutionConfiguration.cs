﻿using Microsoft.Extensions.DependencyInjection;
using UM.Domain.IRepository;
using UM.Infrastructure.Repository;

namespace UM.Infrastructure.Dependency
{
    public static class RepositoryResolutionConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
