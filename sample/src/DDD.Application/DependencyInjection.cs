using DDD.Application.Services;
using DDD.Domain.Interfaces.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Application;

public static class DependencyInjection
{
    public static void AddApplicationDependency(this IServiceCollection services)
    {
        services.AddScoped<ISampleApplicationService, SampleApplicationService>();
    }
}