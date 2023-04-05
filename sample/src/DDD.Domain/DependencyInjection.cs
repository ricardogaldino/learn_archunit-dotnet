using DDD.Domain.Interfaces.Domain.Services;
using DDD.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Domain;

public static class DependencyInjection
{
    public static void AddDomainDependency(this IServiceCollection services)
    {
        services.AddScoped<ISampleDomainService, SampleDomainService>();
    }
}