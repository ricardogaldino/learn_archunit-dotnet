using DDD.Domain.Interfaces.Infrastructure.Database.Repositories;
using DDD.Domain.Interfaces.Infrastructure.Externals.Services;
using DDD.Infrastructure.Database.Repositories;
using DDD.Infrastructure.Externals.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructureDependency(this IServiceCollection services)
    {
        services.AddRepositoryDependency();
        services.AddExternalDependency();
    }

    private static void AddRepositoryDependency(this IServiceCollection services)
    {
        services.AddScoped<ISampleRepository, SampleRepository>();
    }

    private static void AddExternalDependency(this IServiceCollection services)
    {
        services.AddScoped<ISampleExternalService, SampleExternalService>();
    }
}