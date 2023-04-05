using DDD.Application;
using DDD.Domain;
using DDD.Infrastructure;

namespace DDD.UI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddApplicationDependency();
        builder.Services.AddDomainDependency();
        builder.Services.AddInfrastructureDependency();
        builder.Services.AddUIDependency();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}